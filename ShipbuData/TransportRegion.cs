using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipbuData;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ShipbuData;

public class TransportRegion
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }
    public int Volume { get; set; }
    public bool IsOrigin { get; set; }
    public bool IsDestination { get; set; }

    public ICollection<TransportDistrict> Districts { get; set; } = new HashSet<TransportDistrict>();
    public ICollection<TransportMethod> TransportMethods { get; set; } = new HashSet<TransportMethod>();
    public ICollection<TransportRegionMethod> TransportRegionMethods { get; set; } = new HashSet<TransportRegionMethod>();
    public ICollection<TransportOrder> TransportOrders { get; set; } = new HashSet<TransportOrder>();

}

public class TransportRegionEntityTypeConfiguration : IEntityTypeConfiguration<TransportRegion>
{

    public void Configure(EntityTypeBuilder<TransportRegion> builder)
    {
        builder
            .HasMany(p => p.Districts)
            .WithOne(p => p.Region)
            .HasForeignKey(p => p.RegionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(p => p.TransportOrders)
            .WithOne(p => p.Origin)
            .HasForeignKey(p => p.OriginId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(p => p.TransportMethods)
            .WithMany(p => p.TransportRegions)
            .UsingEntity<TransportRegionMethod>();

        builder
            .HasData(
                new TransportRegion { Id = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, Volume = 6000, NameTr = "ABD", NameEn = "USA", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, Volume = 6000, NameTr = "Kanada", NameEn = "Canada", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, Volume = 6000, NameTr = "İngiltere", NameEn = "UK", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, Volume = 6000, NameTr = "Avrupa", NameEn = "Europe", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{A524039F-30F6-4ADF-8CD3-2E0859FD08AB}"), Enabled = true, Volume = 6000, NameTr = "Çin", NameEn = "China", IsDestination = false, IsOrigin = true },
                new TransportRegion { Id = Guid.Parse("{28B14CDC-0695-4F64-B624-C3F9F3662704}"), Enabled = true, Volume = 5000, NameTr = "Türkiye", NameEn = "Turkey", IsDestination = false, IsOrigin = true }
            );
    }
}


public class TransportDistrict
{
    public Guid Id { get; set; }
    public Guid RegionId { get; set; }
    public bool Enabled { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }
    public bool IsAmazonDepot { get; set; }

    public TransportRegion? Region { get; set; }
    public ICollection<TransportOrder> TransportOrders { get; set; } = new HashSet<TransportOrder>();

}

public class TransportDistrictEntityTypeConfiguration : IEntityTypeConfiguration<TransportDistrict>
{

    public void Configure(EntityTypeBuilder<TransportDistrict> builder)
    {

        builder
            .HasMany(p => p.TransportOrders)
            .WithOne(p => p.District)
            .HasForeignKey(p => p.DestinationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasData(
                //USA
                new TransportDistrict { Id = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "Amazon Depo, USA ", NameEn = "Amazon Depo, USA   ", IsAmazonDepot = true },

                new TransportDistrict { Id = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "Doğu Amerika", NameEn = "Eastern USA", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "Merkez Amerika", NameEn = "Central USA", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "Batı Amerika", NameEn = "Western USA", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{2B26B58B-050C-46A7-8567-2325C31FA6FB}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "ONT8", NameEn = "ONT8", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{3BF2DA8A-0A2C-4A8F-99C9-35742CB7FA2E}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "LGB8", NameEn = "LGB8", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{DBE61B00-89EF-493C-8930-9D41A402A987}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "LAX9", NameEn = "LAX9", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{CCD6ECFE-C907-4777-96AD-40AB41B7AC06}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "SBD1", NameEn = "SBD1", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{6D332A8F-0BCD-4B81-9C59-6965F4AB40AE}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "SCK4", NameEn = "SCK4", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{76ADC0F7-AC5D-43CD-9983-EAE135865030}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "SMF3", NameEn = "SMF3", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{80FF3E90-DCB9-4BC3-9590-E3A2C331A0EC}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "VGT2", NameEn = "VGT3", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{72516348-D8E7-4CE3-AF4E-F97B77897F89}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "GYR2", NameEn = "GYR2", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{5F0411D9-FC63-4DD4-A03F-50C26F0829C6}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "GYR3", NameEn = "GYR3", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{76E0D1B5-4FB7-4DC7-BCB1-1FADFF9ACC92}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "LAS1", NameEn = "LAS1", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{123A8E96-B5F2-4459-A896-DA06599036CF}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "SJC7", NameEn = "SJC7", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{98EAD996-828C-4A6F-99C2-914B7C8110EF}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "KRB1", NameEn = "KRB1", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{5ABCB711-259A-48DC-9817-2E5B988D690A}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "KRB4", NameEn = "KRB4", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{B90943D8-F764-42D3-8FCA-DA1BA2378634}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "SBD2", NameEn = "SBD2", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{6D63584C-813F-48DE-9B19-DF143F83D2F7}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "SBD3", NameEn = "SBD3", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{D484CF5D-D07D-4E01-8AA4-C87747FA68FE}"), RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "FTW1", NameEn = "FTW1", IsAmazonDepot = true },
                 //CANADA
                new TransportDistrict { Id = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Amazon Depo, CANADA ", NameEn = "Amazon Depo, CANADA   ", IsAmazonDepot = true },

                new TransportDistrict { Id = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Vancouver YVR", NameEn = "Vancouver YVR", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Calgary YYC", NameEn = "Calgary YYC", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Calgary YEG", NameEn = "Calgary YEG", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Toronto YYZ", NameEn = "Toronto YYZ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ottawa YOW", NameEn = "Ottawa YOW", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ottawa YUL", NameEn = "Ottawa YUL", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Kurumsal/Bireysel Adres", NameEn = "Bussiness Private Address", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Edmonton YEG1", NameEn = "Edmonton YEG1", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Toronto YOO", NameEn = "Toronto YOO", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Toronto YHM", NameEn = "Toronto YHM", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Vancouver YXX", NameEn = "Vancouver YXX", IsAmazonDepot = true },
                // Yeni Amazon Depo  CANADA
                new TransportDistrict { Id = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "British Columbia YVR2", NameEn = "British Columbia YVR2", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "British Columbia YVR4", NameEn = "British Columbia YVR4", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario L5N 1L8 YYZ1", NameEn = "Ontario L5N 1L8 YYZ1", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario L9T 6Y9 YYZ2", NameEn = "Ontario L9T 6Y9 YYZ2", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario L6Y 0B2 YYZ3", NameEn = "Ontario L6Y 0B2 YYZ3", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario L6Y 0C9 YYZ4-YYZ6", NameEn = "Ontario  L6Y 0C9 YYZ4-YYZ6", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario L7E 4L8 YYZ7", NameEn = "Ontario L7E 4L8 YYZ7", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario L5R 3W PRTO", NameEn = "Ontario L5R 3W PRTO", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Ontario Canada K4N 1P6 YOW1 ", NameEn = "Ontario Canada K4N 1P6 YOW1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Balzac, Alberta T4A 1C6 YYC1 ", NameEn = "Balzac, Alberta T4A 1C6 YYC1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Leduc County, AB T6W 1A7 YEG1 ", NameEn = "Leduc County, AB T6W 1A7 YEG1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Delta, BC V3M 5Y9 YVR2 ", NameEn = "Delta, BC V3M 5Y9 YVR2 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Montréal (Lachine) – Waze YUL2 ", NameEn = "Montréal (Lachine) – Waze YUL2 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Toronto YYZ9 ", NameEn = "Toronto YYZ9 ", IsAmazonDepot = true },

                 //UK AMAZON DEPO
                 new TransportDistrict { Id = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Amazon Depo, UK ", NameEn = "Amazon Depo, UK   ", IsAmazonDepot = true },

                 new TransportDistrict { Id = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Staffordshire, UK  BHX1", NameEn = "Staffordshire, UK  BHX1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Coalville, UK  BHX2", NameEn = "Coalville, UK  BHX2", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Northamptonshire, UK  BHX3", NameEn = "Northamptonshire, UK  BHX3", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Great Britain  BHX4", NameEn = "Great Britain BHX4", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Swansea, UK  CWL1", NameEn = "Swansea, UK  CWL1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Dunfermline, UK  EDI4", NameEn = "Dunfermline, UK  EDI4", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Peterborough, UK  EUK5", NameEn = "Peterborough, UK  EUK5", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Inverclyde, UK GLA1", NameEn = " Inverclyde, UK  GLA1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = " Doncaster, UK LBA1", NameEn = "  Doncaster, UK  LBA1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = " Doncaster, UK LBA2", NameEn = "  Doncaster, UK  LBA2", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = " Doncaster, UK LBA3", NameEn = "  Doncaster, UK  LBA3", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = " London, UK LCY1", NameEn = "  London, UK LCY1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Tilbury, UK LCY2", NameEn = " Tilbury, UK LCY2", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Bedfordshire, UK LTN1", NameEn = " Bedfordshire, UK LTN1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Hertfordshire, UK LTN2", NameEn = " Hertfordshire, UK LTN2", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Dunstable, UK LTN4", NameEn = " Dunstable, UK LTN4", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Manchester, UK MAN1", NameEn = "Manchester, UK MAN1", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Warrington, UK MAN2", NameEn = "Warrington, UK MAN2", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Cheshire, UK XUKA", NameEn = "Cheshire, UK XUKA", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "Wellingborough, UK XUKC", NameEn = "Wellingborough, UK XUKC", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = " Daventry, UK XUKD", NameEn = "Daventry, UK XUKD", IsAmazonDepot = true },
                 new TransportDistrict { Id = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = " Birmingham, UK XUKK", NameEn = "Birmingham, UK XUKK", IsAmazonDepot = true },



                //UK

                new TransportDistrict { Id = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "İngiltere", NameEn = "UK", IsAmazonDepot = false },
                 //EUROPE
                 new TransportDistrict { Id = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Amazon Depo, EUROPE ", NameEn = "Amazon Depo, EUROPE ", IsAmazonDepot = true },

                new TransportDistrict { Id = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Almanya", NameEn = "Germany", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Brieselang,Almanya BER3   ", NameEn = "Brieselang, Loiret, Germany BER3   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Am Borsigturm 100, 13507 Berlin,Almanya BER6   ", NameEn = "Am Borsigturm 100, 13507 Berlin Germany BER6   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Kobern-Gondorf,Almanya CGN1    ", NameEn = "Kobern-Gondorf, Germany CGN1    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Werne,Almanya DTM1    ", NameEn = "Werne, Germany DTM1    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Dortmund,Almanya DTM2   ", NameEn = "Dortmund, Germany DTM2   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Rheinberg,Almanya DUS2   ", NameEn = "Rheinberg, Germany DUS2   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Werne,Almanya EDE4   ", NameEn = "Werne, Germany EDE4   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Werne,Almanya EDE5   ", NameEn = "Werne, Germany EDE5   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Bad Hersfeld,Almanya FRA1   ", NameEn = "Bad Hersfeld, Germany FRA1   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Bad Hersfeld,Almanya FRA3   ", NameEn = "Bad Hersfeld, Germany FRA3   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Winsen an der Luhe,Almanya HAM2   ", NameEn = "Winsen an der Luhe, Germany HAM2   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Leipzig,Almanya LEJ1    ", NameEn = "Leipzig, Germany LEJ1    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Leipzig,Almanya LEJ2    ", NameEn = "Leipzig, Germany LEJ2    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Graben,Almanya MUC3   ", NameEn = "Graben, Germany MUC3   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Pforzheim,Almanya STR1    ", NameEn = "Pforzheim, Germany STR1    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Ludwigsau OT Mecklar,Almanya XDEB    ", NameEn = "Ludwigsau OT Mecklar, Germany XDEB    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Rennerod,Almanya XDEH    ", NameEn = "Rennerod, Germany XDEH    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Mienenbuettel,Almanya XDEI   ", NameEn = "Mienenbuettel, Germany XDEI    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Sonnefeld,Almanya XDEJ    ", NameEn = "Sonnefeld, Germany XDEJ    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Löhne,Almanya XDES    ", NameEn = "Löhne, Germany XDES    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Mansfeld,Almanya XDET    ", NameEn = "Mansfeld, Germany XDET    ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Euskirchen,Almanya XDEU    ", NameEn = "Euskirchen, Germany XDEU    ", IsAmazonDepot = true },


                new TransportDistrict { Id = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Fransa", NameEn = "France", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Saran, Loiret,Fransa ORY1   ", NameEn = "Saran, Loiret, France ORY1   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Montelimar, Drôme,Fransa MRS1  ", NameEn = "Montelimar, Drôme, France MRS1  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Burgundy,Fransa LYS1   ", NameEn = "Burgundy, France LYS1   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Norde-Pas-de-Calais,Fransa LIL1   ", NameEn = "Norde-Pas-de-Calais, France LIL1   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Boves, Somme,Fransa BVA1   ", NameEn = "Boves, Somme, France BVA1   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Auvergne-Rhône-Alpes,Fransa XFRE   ", NameEn = "Auvergne-Rhône-Alpes, France XFRE   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Châtres, Île-de,Fransa XFRF   ", NameEn = "Châtres, Île-de, France XFRF   ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Centre-Val de Loire,Fransa XFRG  ", NameEn = "Centre-Val de Loire,Fransa XFRG  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Moissy-Cramayel, Île-de,Fransa XFRH  ", NameEn = "Moissy-Cramayel, Île-de, France XFRH  ", IsAmazonDepot = true },

                new TransportDistrict { Id = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Polonya", NameEn = "Poland", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Sosnowiec Poland KTW1 ", NameEn = "Sosnowiec Poland KTW1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Sady, Poland POZ1 ", NameEn = "Sady, Poland POZ1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = " Gliwice, Poland KTW3 ", NameEn = "Gliwice, Poland KTW3 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Kolbaskowo, Poland SZZ1", NameEn = "Kolbaskowo, Poland SZZ1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Wroclawskie Poland WRO1 ", NameEn = "Wroclawskie Poland WRO1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Wroclawskie Poland WRO2 ", NameEn = "Wroclawskie Poland WRO2 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Wroclawskie Poland WRO3 ", NameEn = "Wroclawskie Poland WRO3 ", IsAmazonDepot = true },

                new TransportDistrict { Id = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Çekya", NameEn = "Czech Rep.", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Dobrovíz, CZ PRG1 ", NameEn = "Dobrovíz, CZ PRG1 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Dobrovíz, CZ PRG2", NameEn = "Dobrovíz, CZ PRG2 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Belçika", NameEn = "Belgium", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Avusturya", NameEn = "Austria", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Lüksemburg", NameEn = "Luxembourg", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "İspanya", NameEn = "Spain", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "El Prat de Llobregat, Barcelona, İspanya BCN1  ", NameEn = "El Prat de Llobregat, Barcelona, Spain BCN1  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Martorelles, İspanya BCN2  ", NameEn = "Martorelles, Spain BCN2  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Castellbisbal, Barcelona, İspanya BCN3  ", NameEn = "Castellbisbal, Barcelona, Spain BCN3  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "San Fernando De Henares, Madrid, İspanya MAD4 ", NameEn = "San Fernando De Henares, Madrid, Spain MAD4 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Poligono de Los Vailanes, 28096 Madrid, İspanya MAD5 ", NameEn = "Poligono de Los Vailanes, 28096 Madrid, Spain MAD5 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Alovera, Guadalajara, İspanya XESA  ", NameEn = "Alovera, Guadalajara, Spain XESA  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Alovera, Guadalajara, İspanya XESB  ", NameEn = "Alovera, Guadalajara, Spain XESB  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Constantí, Tarragona, İspanya XESC  ", NameEn = "Constantí, Tarragona, Spain XESC  ", IsAmazonDepot = true },


                new TransportDistrict { Id = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "İtalya", NameEn = "Italy", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Passo Corese ,İtalya FCO1", NameEn = "Passo Corese, Italy FCO1", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Vercelli,İtalya MXP3  ", NameEn = "Vercelli, Italy MXP3  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Castel San Giovanni,İtalya MXP5 ", NameEn = "Castel San Giovanni, Italy MXP5 ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Torrazza Piedmonte,İtalya TRN1  ", NameEn = "Torrazza Piedmonte, Italy TRN1  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Francolino di Carpiano,İtalya XITC  ", NameEn = "Francolino di Carpiano, Italy XITC  ", IsAmazonDepot = true },
                new TransportDistrict { Id = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Arquà Polesine,İtalya XITD ", NameEn = "Arquà Polesine, Italy XITD ", IsAmazonDepot = true },

                new TransportDistrict { Id = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Hollanda", NameEn = "Netherlands", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Yunanistan", NameEn = "Greece", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Danimarka", NameEn = "Denmark", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "İsveç", NameEn = "Sweden", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Finlandiya", NameEn = "Finland", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Slovakya", NameEn = "Slovakia", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Slovenya", NameEn = "Slovenia", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Macaristan", NameEn = "Hungary", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Portekiz", NameEn = "Portugal", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Hırvatistan", NameEn = "Croatia", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Estonya", NameEn = "Estonia", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Latviya", NameEn = "Latvia", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Bulgaristan", NameEn = "Bulgaria", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Monako", NameEn = "Monaco", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Irlanda", NameEn = "Ireland", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Litvanya", NameEn = "Lithuania", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Romanya", NameEn = "Romania", IsAmazonDepot = false }
            );
    }
}


public class TransportMethod
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }

    public ICollection<TransportRegion> TransportRegions { get; set; } = new HashSet<TransportRegion>();
    public ICollection<TransportRegionMethod> TransportRegionMethods { get; set; } = new HashSet<TransportRegionMethod>();

}

public class TransportMethodEntityTypeConfiguration : IEntityTypeConfiguration<TransportMethod>
{

    public void Configure(EntityTypeBuilder<TransportMethod> builder)
    {
        builder
            .HasData(
                new TransportMethod { Id = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), NameTr = "Uçak", NameEn = "Air", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), NameTr = "Yavaş Gemi + Ekspress", NameEn = "Sea Slow + Express", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), NameTr = "Hızlı Gemi + Ekspress", NameEn = "Sea Fast + Express", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{2ADD124B-9A78-4B78-96D1-523E658F77A4}"), NameTr = "Yavaş Gemi + TIR", NameEn = "Sea Slow + Truck", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{4F2FEBE8-3273-4086-89A4-0A0282F003A8}"), NameTr = "Hızlı Gemi + TIR", NameEn = "Sea Fast + Truck", Enabled = true },
                //new TransportMethod { Id = Guid.Parse("{730CD01E-FB25-4347-8932-2B4056252E73}"), NameTr = "Speed Boat", NameEn = "Fast Vessel", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{AF3E3B1A-06D9-413F-99AD-3378458BE832}"), NameTr = "TIR", NameEn = "Truck", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{A5FE9692-EF46-4376-919F-43AEAA0C07A0}"), NameTr = "Tren", NameEn = "Railway", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{C2A145A8-C7D9-4241-9D21-8BB4968C39CF}"), NameTr = "Gemi", NameEn = "Sea", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD}"), NameTr = "Gemi + Sınırlı Zaman", NameEn = "Sea + Limited Time", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{C1637D89-CCB7-4A68-B382-40B4BB9E50D7}"), NameTr = "Gemi + Sınırlı Zaman + TIR", NameEn = "Fast Vessel+Truck+Limited Time ", Enabled = true }

            );
    }
}


public class TransportRegionMethod
{
    public Guid RegionId { get; set; }
    public Guid MethodId { get; set; }
    public int? ETAMin { get; set; }
    public int? ETAMax { get; set; }

    public TransportRegion? Region { get; set; }
    public TransportMethod? Method { get; set; }
}

public class TransportRegionMethodEntityTypeConfiguration : IEntityTypeConfiguration<TransportRegionMethod>
{

    public void Configure(EntityTypeBuilder<TransportRegionMethod> builder)
    {
        //builder
        //    .HasKey(p => new { p.RegionId, p.MethodId });

        builder
            .HasData(
                //USA
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), ETAMin = 3, ETAMax = 5 },
                //new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{730CD01E-FB25-4347-8932-2B4056252E73}"), ETAMin = 3, ETAMax = 5 },
                //CANADA  
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{2ADD124B-9A78-4B78-96D1-523E658F77A4}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{4F2FEBE8-3273-4086-89A4-0A0282F003A8}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{C1637D89-CCB7-4A68-B382-40B4BB9E50D7}"), ETAMin = 3, ETAMax = 5 },
                //new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{730CD01E-FB25-4347-8932-2B4056252E73}"), ETAMin = 3, ETAMax = 5 },

                //UK
                new TransportRegionMethod { RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), MethodId = Guid.Parse("{C2A145A8-C7D9-4241-9D21-8BB4968C39CF}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), MethodId = Guid.Parse("{AF3E3B1A-06D9-413F-99AD-3378458BE832}"), ETAMin = 3, ETAMax = 5 },
                //Europe
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{C2A145A8-C7D9-4241-9D21-8BB4968C39CF}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{A5FE9692-EF46-4376-919F-43AEAA0C07A0}"), ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{AF3E3B1A-06D9-413F-99AD-3378458BE832}"), ETAMin = 3, ETAMax = 5 }

            );

    }
}


public class TransportFee
{
    public Guid Id { get; set; }
    public Guid DistrictId { get; set; }
    public Guid MethodId { get; set; }
    public decimal Value { get; set; }

    public int MinWeight { get; set; }
    public int? MaxWeight { get; set; }

    public TransportDistrict? District { get; set; }
    public TransportMethod? Method { get; set; }

    public ICollection<TransportOrder> TransportOrders { get; set; } = new HashSet<TransportOrder>();
}

public class TransportFeeEntityTypeConfiguration : IEntityTypeConfiguration<TransportFee>
{

    public void Configure(EntityTypeBuilder<TransportFee> builder)
    {
        builder
            .HasMany(p => p.TransportOrders)
            .WithOne(p => p.TransportFee)
            .HasForeignKey(p => p.TransportFeeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasData(

                //ABD   
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 23, MaxWeight = 70, Value = 2.37m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 71, MaxWeight = 100, Value = 2.22m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = 300, Value = 1.57m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 301, MaxWeight = 1500, Value = 1.50m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 1501, MaxWeight = null, Value = 1.47m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 70, Value = 2.84m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.70m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.06m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 1500, Value = 1.98m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5540A389-BD6B-4985-A356-27038D276D14}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1501, MaxWeight = null, Value = 1.95m },







                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 23, MaxWeight = 70, Value = 2.37m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 71, MaxWeight = 100, Value = 2.22m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = 300, Value = 1.57m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 301, MaxWeight = 1500, Value = 1.50m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 1501, MaxWeight = null, Value = 1.47m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 23, MaxWeight = 70, Value = 2.22m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 71, MaxWeight = 100, Value = 2.08m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = 300, Value = 1.43m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 301, MaxWeight = 1500, Value = 1.36m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 1501, MaxWeight = null, Value = 1.33m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 23, MaxWeight = 70, Value = 2.08m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 71, MaxWeight = 100, Value = 1.93m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = 300, Value = 1.57m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 301, MaxWeight = 1500, Value = 1.82m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 1501, MaxWeight = null, Value = 1.82m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B26B58B-050C-46A7-8567-2325C31FA6FB}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B26B58B-050C-46A7-8567-2325C31FA6FB}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B26B58B-050C-46A7-8567-2325C31FA6FB}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.43m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3BF2DA8A-0A2C-4A8F-99C9-35742CB7FA2E}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3BF2DA8A-0A2C-4A8F-99C9-35742CB7FA2E}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3BF2DA8A-0A2C-4A8F-99C9-35742CB7FA2E}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.46m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DBE61B00-89EF-493C-8930-9D41A402A987}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DBE61B00-89EF-493C-8930-9D41A402A987}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DBE61B00-89EF-493C-8930-9D41A402A987}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.46m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CCD6ECFE-C907-4777-96AD-40AB41B7AC06}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CCD6ECFE-C907-4777-96AD-40AB41B7AC06}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CCD6ECFE-C907-4777-96AD-40AB41B7AC06}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.46m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6D332A8F-0BCD-4B81-9C59-6965F4AB40AE}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6D332A8F-0BCD-4B81-9C59-6965F4AB40AE}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.00m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6D332A8F-0BCD-4B81-9C59-6965F4AB40AE}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.53m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{76ADC0F7-AC5D-43CD-9983-EAE135865030}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{76ADC0F7-AC5D-43CD-9983-EAE135865030}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.00m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{76ADC0F7-AC5D-43CD-9983-EAE135865030}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.53m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{80FF3E90-DCB9-4BC3-9590-E3A2C331A0EC}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{80FF3E90-DCB9-4BC3-9590-E3A2C331A0EC}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.00m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72516348-D8E7-4CE3-AF4E-F97B77897F89}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72516348-D8E7-4CE3-AF4E-F97B77897F89}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72516348-D8E7-4CE3-AF4E-F97B77897F89}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.53m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5F0411D9-FC63-4DD4-A03F-50C26F0829C6}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5F0411D9-FC63-4DD4-A03F-50C26F0829C6}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5F0411D9-FC63-4DD4-A03F-50C26F0829C6}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.53m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{76E0D1B5-4FB7-4DC7-BCB1-1FADFF9ACC92}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{76E0D1B5-4FB7-4DC7-BCB1-1FADFF9ACC92}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 0.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{76E0D1B5-4FB7-4DC7-BCB1-1FADFF9ACC92}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.53m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{123A8E96-B5F2-4459-A896-DA06599036CF}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{123A8E96-B5F2-4459-A896-DA06599036CF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{123A8E96-B5F2-4459-A896-DA06599036CF}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.61m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{98EAD996-828C-4A6F-99C2-914B7C8110EF}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{98EAD996-828C-4A6F-99C2-914B7C8110EF}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{98EAD996-828C-4A6F-99C2-914B7C8110EF}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.61m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5ABCB711-259A-48DC-9817-2E5B988D690A}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5ABCB711-259A-48DC-9817-2E5B988D690A}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5ABCB711-259A-48DC-9817-2E5B988D690A}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.61m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B90943D8-F764-42D3-8FCA-DA1BA2378634}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B90943D8-F764-42D3-8FCA-DA1BA2378634}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B90943D8-F764-42D3-8FCA-DA1BA2378634}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.61m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6D63584C-813F-48DE-9B19-DF143F83D2F7}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6D63584C-813F-48DE-9B19-DF143F83D2F7}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6D63584C-813F-48DE-9B19-DF143F83D2F7}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.61m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D484CF5D-D07D-4E01-8AA4-C87747FA68FE}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D484CF5D-D07D-4E01-8AA4-C87747FA68FE}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), MinWeight = 101, MaxWeight = null, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D484CF5D-D07D-4E01-8AA4-C87747FA68FE}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), MinWeight = 101, MaxWeight = null, Value = 1.92m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 70, Value = 2.84m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.70m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.06m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 1500, Value = 1.98m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{05BB9082-20A8-4114-946B-CCE72CEDAB19}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1501, MaxWeight = null, Value = 1.95m },


                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 70, Value = 2.70m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.55m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.90m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 1500, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0C02AA0A-B0D4-477A-B4E9-0A5073D323BF}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1501, MaxWeight = null, Value = 1.80m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 70, Value = 2.55m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.41m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 1500, Value = 1.69m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{34E425DB-FF6C-4AB7-AC14-A1BD7A7C94A8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1501, MaxWeight = null, Value = 1.66m },


                //UK-AIR   

         

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },


                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },

                 //UK SEA
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                         
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
            
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                //UK TRUCK
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.46m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 4.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 4.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.81m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.74m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.67m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.64m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.46m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 4.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 4.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.81m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.74m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.67m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{184751A1-2C5F-4564-BC93-67290D40FB4F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.64m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CD411066-BD30-4486-90B5-70BFC5FBBD42}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A2CC80A3-21E3-4D6B-861F-531FAAB216D2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE6A8AED-2DD1-4282-9E9D-68AF2BAB90B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2BC25DF-53F7-49AB-B371-A4B197976C7C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{23469610-8E94-45FE-B14E-D8BCA0FEC881}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E0283B75-D682-4C05-B857-220C53224E37}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{258456BE-CD6F-425C-81E9-598381246863}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3CE6D62F-5651-41E0-8499-7685F6D66F63}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EB69FAFB-63C1-430B-B9B4-269814C2291F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CF75BF3D-E50A-4D09-8BAB-49A3AD643BEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8FB70AB3-B2F2-4D76-AA47-ABAC081D2194}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36D809A5-8740-473A-8FA4-3220384F6653}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72A5BF72-3A7B-4E9F-ACE3-A854137AA994}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                               
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C0B6CE32-7AA6-4F37-BFDD-5B962B3E9B14}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C410D87-A2C3-4DC5-B5E1-CB9DB7181EF6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2D74FA83-617F-4449-BEAF-9F9D3773D050}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{95964A73-03F0-463E-9424-0E33DC9F2F95}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{27B2B7BA-686C-4322-8537-23A31E9B4672}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DAE49CAC-E502-47FF-BB0A-3D0E854E698D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{079E24BF-88C7-47B5-91D0-404C645D3140}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6F349051-E7A4-4B0F-BB7F-6E3193EB779A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },
                                                                                                                                                  
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{37E5E803-58A1-492A-B4CF-58F0BA368632}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },




                //CANADA AIR      



                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                // 431D73FB Bu id ile başlayan amazona gitmiyorsa 
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },

                //CANADA YENİLER
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },

         
                //CANADA SEA SLOW+ EXPRESS   

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.47m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.90m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.58m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.47m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{82060812-B989-4340-BD2E-8840585A8ACF}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.37m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.47m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.90m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.47m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.37m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.40m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.65m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.54m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.47m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.44m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.55m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.90m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.58m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.55m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 1.97m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 1.90m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.61m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FF9E1EE3-91CC-404F-AE3F-4A4C8AD891F7}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.58m },
                 // AMAZONA GİTMİYORSA
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 23, MaxWeight = 45, Value = 2.76m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 46, MaxWeight = 70, Value = 2.19m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 71, MaxWeight = 100, Value = 2.12m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 301, MaxWeight = 500, Value = 1.90m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 501, MaxWeight = 999, Value = 1.83m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("96E1EF5B-916C-4885-AE5B-08A98541E92A"), MinWeight = 1000, MaxWeight = null, Value = 1.80m },


                  //CANADA SEA SLOW + TRUCK   

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.15m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.12m },



                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.15m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.12m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.15m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.12m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.15m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.12m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.19m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.19m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.22m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.19m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },


                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

               
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },


                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("2ADD124B-9A78-4B78-96D1-523E658F77A4"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                  //CANADA SEA FAST+EXPRESS               
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },


                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.33m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 1.76m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 1.68m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.44m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 2.6m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 2.20m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 2.20m },

                 //AMAZONA GİTMİYORSA
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 3.06m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.78m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.56m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 2.35m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 2.20m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 2.13m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 2.10m },

                 //SEA FAST + TRUCK   

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },





                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.58m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.55m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.84m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.84m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.84m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.70m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.84m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 501, MaxWeight = 999, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("4F2FEBE8-3273-4086-89A4-0A0282F003A8"), MinWeight = 1000, MaxWeight = null, Value = 1.70m },

                      //SEA LIMITED  TIME   

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.56m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.56m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.56m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.60m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.60m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.17m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{637A3CF8-E91A-4E46-8CCF-D1BFCBAA19E3}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.99m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.17m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9495DD9F-53C2-41C5-8680-34539A483A42}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.99m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.17m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.99m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.17m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A42EA92C-D563-4EB8-BD25-83A3AC1217DC}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 2.99m },

                 //AMAZONA GİTMİYORSA
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 4.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 4.17m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 301, MaxWeight = 500, Value = 3.17m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 501, MaxWeight = 999, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{431D73FB-827D-43C2-8EE3-98568D1CFCF8}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 1000, MaxWeight = null, Value = 3.06m },

                   //SEA  FAST VESSEL+LIMITED TIME+TRUCK  

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{794704E2-2B5A-48C4-8663-00BAD12B34BC}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{32D1B488-73D7-41F5-A1FD-641041F8144D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8B980AF-CC6C-4F4B-9520-C976454D5C81}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7108B599-3916-41B4-8A3A-9A13014421B6}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5C53B65C-4BFB-4B3E-A49C-C61EE219204F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F0EFA456-CD90-4783-A75E-08E602259182}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A4480B57-775D-46FC-9482-83AC8C0A1A6D}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CBF7DF95-3B02-4F6D-B46D-5845121BBA8B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{44F51AA3-F033-4DFD-AE91-5404B99CED75}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C43EA434-7FF0-4282-92CB-B16339ECFA73}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CA29F053-832D-4477-B30C-039D085000E5}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{31084077-3241-4490-89DD-9908441A2F6E}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38AA7336-5832-47C6-8F49-F38719A92475}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FEB4EB90-9EB7-4DD3-896E-B0AAEB438240}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DB8EDF7B-09F7-41AC-85BF-8DFD6C663A69}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },






                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE1CFC73-52A1-4C72-AED7-1C67A588E436}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BB88A4E3-A99F-45E4-A753-CB430B608A4F}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 101, MaxWeight = 300, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 301, MaxWeight = 500, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 501, MaxWeight = 999, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{829F6814-B1A3-43F0-8D71-F2EA928E743B}"), MethodId = Guid.Parse("C1637D89-CCB7-4A68-B382-40B4BB9E50D7"), MinWeight = 1000, MaxWeight = null, Value = 2.42m },



                 //EUROPE AIR   

                 

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10.0m },

                 //EUROPE SEA 
                 
            

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },



                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },




                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },



                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 2.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.92m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 3.10m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 3.10m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 3.10m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 3.10m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 3.10m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 3.10m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 2.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 2.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },


                 // EUROPE TRUCK     


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },



                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },







                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },






                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.56m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 3.74m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.56m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.03m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.03m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.02m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 2.88m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 2.85m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3B2F9FD2-134D-438F-817B-74378C2CEB0B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{803E5FB5-2A8F-4E42-A544-071B0B9FCECF}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.39m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 3.67m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.38m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.24m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3A52E207-C517-49A2-98D4-2998F29F1ECD}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.21m },


                 //EUROPE TRAİN  

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02C382B0-E16A-46A5-9217-9D2F7C663EEE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C550C432-8CB1-4721-B518-7D8575100F31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{959E9640-1EC5-4A73-9BA1-A43CEDC45510}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCEA1FC1-DD1F-4EAE-BCA3-0B230303AF47}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8C3D1B47-B37C-4826-99AF-99B7F50F3220}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DE62FA9F-AE7B-40D7-9B24-886353350CA0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D7ACA4F9-4B6A-4472-96F9-A087CF48F73A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2B78E101-FD97-48D8-AAFD-C5146B3DC406}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B2736D65-3489-4216-ABD5-F50C74C2B1AE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F325582-BBA6-47D2-9219-799EED175FAF}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DC1FE907-1EA7-49EF-A4C4-29D70C6066C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C8EFB3E5-E57F-4F21-9036-132E38D1DD13}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{02444032-2EB7-4D74-AA37-EBF2FB301D26}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{A8D41932-93F2-4B3D-AF88-27C0A2715610}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{5DD57FE7-EE87-4598-BE81-2A8E4D3BC03E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{0806524B-8C27-4310-B003-E8971CA9899A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{36BAB354-2B2F-463D-8615-7305CF51117C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E35F27EA-031C-4A39-A414-4C647D58A540}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BBB9DACC-2424-4C6B-8CE4-58B145F62FDD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{96402DD4-1BC2-4237-A5B2-3AADFF20C6C4}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E882FA42-F73A-4730-8476-48904A2F83BE}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{01202F4B-0D1C-4EB5-9F9E-610459EA46D6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },





                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{D40C19A9-1B43-4EAA-8E44-8A880203029D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E771BA96-B9E9-43CD-9398-17634FE9C01A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                               
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{59F64A6F-7CA9-44A9-9AA2-F43BCBFFA80E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FFC5F2AB-1D8A-499C-BA5E-D2337A70DF31}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7F7B070B-3B61-4B78-B117-6445AD12A0DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{4857DF3A-03EB-484B-ACD0-E41C7220A585}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E4E37518-ED71-4E65-A73A-AF4F6D7675B3}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{ECA2414B-B0EC-4D87-909C-E8DDDAA4BA0C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F007A19E-2913-4716-BE8E-06F0568636FD}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{608513AB-64D3-4280-876B-0ABD5AA8494C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{9631EAC5-F254-43F1-8C10-65740A8C4F57}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B7DDCA29-5CDB-4E58-89F0-8791543A6977}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{13F73FF4-D3A0-4E9C-A5BC-DCF9967EEA12}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{C186EB4C-060D-4ACC-A0C5-75C7F435CFE0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{50A7B328-1CED-4490-BC79-604D0C7BCF22}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{85932109-597B-407E-AF3F-592B66A4B2DC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8534D7BF-4660-40CA-9AEF-32429443484A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{93192601-5BC6-44F7-8EB8-AB70947D2483}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FADD3554-06BE-40E4-A935-C2FC14134E5E}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FBC0736C-4CCF-4AE9-A322-6BB09603080B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3F0275BD-9D4F-489A-B88E-A76003D32EC1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{FCAF0A05-AD58-4A0B-878D-BA6DFBF469BB}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                  
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F2268419-DCE3-485B-BF18-3341FE37FE58}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },






                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{17CEB323-98D4-4457-B45F-0641A2911098}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                              
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{1A583846-CFE5-424A-AFD9-B1D8D3BD0875}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F3C81F2E-C13F-4277-9A8B-E54BD217BEDC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{2274F3F8-EA4D-42D8-A272-016425CF9187}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{49CBE04D-3F08-426F-9C64-32B08EA1683F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                               
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{438E47D5-4CEA-4401-914E-9C109DA0E353}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                 
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F90F6C2B-EF48-4591-934E-898626025A93}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },



                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{72169074-DEA6-4455-88BF-FB68F946B295}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },
                                                                                                                                                   
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.32m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BD3A5738-8770-4DB3-BF0C-2FF7807D13C2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.51m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.44m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{F43F05BD-F741-43E4-B999-C7731999D5C6}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },



                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.52m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.51m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.44m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.29m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.27m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.65m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.63m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.59m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{52E63491-43B4-47CC-B53E-8384AAC7C07C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{58A45E41-A7FE-4DEC-9A8E-3BBF38455E5F}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{EE896FE1-1434-4136-A70E-D2C9FA49D902}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{3C4FEDCC-EAEB-4480-8574-C759E9AA2F9D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA5D4F5E-79AC-4B69-B0F5-CF027053EC8C}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{BC3767BC-68D7-400D-AE61-707FC3BB5878}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{291C8B1E-1EB6-4BC0-B714-86E79ED31316}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 2.95m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 2.73m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.37m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.16m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{6DE69DB5-E0A5-4FE3-95A9-DF3721F50D0B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 1.91m },




                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7B21A66-1C15-49CF-9FF9-C8B3455BA57D}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7777C20-3ABB-4A39-AF05-11FCEE8F7534}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{B93226D5-2642-4705-99CA-734AF02C624B}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{DA7B0A60-D6CA-44D4-9E28-D5D804CD7A64}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{869993CB-CCD8-498F-880C-97F0E02F2846}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 2.06m },


                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 23, MaxWeight = 45, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 46, MaxWeight = 70, Value = 3.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 71, MaxWeight = 100, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 101, MaxWeight = 300, Value = 2.30m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 301, MaxWeight = 500, Value = 2.23m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 501, MaxWeight = 999, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{18351822-A469-408C-B8A9-F17DBFF1020A}"), MethodId = Guid.Parse("A5FE9692-EF46-4376-919F-43AEAA0C07A0"), MinWeight = 1000, MaxWeight = null, Value = 2.06m }



                 );
    }
}