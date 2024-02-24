using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipbuData;
using System.ComponentModel.DataAnnotations;

namespace ShipbuData;

public class TransportRegion
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }

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
                new TransportRegion { Id = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), Enabled = true, NameTr = "ABD", NameEn = "USA", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), Enabled = true, NameTr = "Kanada", NameEn = "Canada", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "İngiltere", NameEn = "UK", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Avrupa", NameEn = "Europe", IsDestination = true, IsOrigin = false },
                new TransportRegion { Id = Guid.Parse("{A524039F-30F6-4ADF-8CD3-2E0859FD08AB}"), Enabled = true, NameTr = "Çin", NameEn = "China", IsDestination = false, IsOrigin = true }
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
                //UK
                new TransportDistrict { Id = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), Enabled = true, NameTr = "İngiltere", NameEn = "UK", IsAmazonDepot = false },
                //EUROPE
                new TransportDistrict { Id = Guid.Parse("{CB7FA78D-6DE7-4838-9E54-C279BEA798B0}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Almanya", NameEn = "Germany", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{78587899-2653-4BE7-B07E-13A7596D5649}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Fransa", NameEn = "France", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{E1371A95-DAA6-4C22-8BCD-C86E5EE03203}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Polonya", NameEn = "Poland", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{CB39B0C9-34BB-4F55-A39B-A575AFF157B2}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Çekya", NameEn = "Czech Rep.", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{660348C5-B814-42BF-A1B9-DF56696F3C75}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Belçika", NameEn = "Belgium", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{38DF3F9B-F88B-4C6D-9A36-76FE0D3E1792}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Avusturya", NameEn = "Austria", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{8603813C-D724-4D63-8013-C273C9FE5FBC}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "Lüksemburg", NameEn = "Luxembourg", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{7DDB170B-5696-4ABE-A5A8-B6424A966BA9}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "İspanya", NameEn = "Spain", IsAmazonDepot = false },
                new TransportDistrict { Id = Guid.Parse("{8B08542B-6C77-4D8E-8D54-329CEEC6C1E1}"), RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), Enabled = true, NameTr = "İtalya", NameEn = "Italy", IsAmazonDepot = false },
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
                new TransportMethod { Id = Guid.Parse("{730CD01E-FB25-4347-8932-2B4056252E73}"), NameTr = "Speed Boat", NameEn = "Fast Vessel", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{AF3E3B1A-06D9-413F-99AD-3378458BE832}"), NameTr = "TIR", NameEn = "Truck", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{A5FE9692-EF46-4376-919F-43AEAA0C07A0}"), NameTr = "Tren", NameEn = "Railway", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{C2A145A8-C7D9-4241-9D21-8BB4968C39CF}"), NameTr = "Gemi", NameEn = "Sea", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD}"), NameTr = "Gemi + Sınırlı Zaman", NameEn = "Sea + Limited Time", Enabled = true },
                new TransportMethod { Id = Guid.Parse("{C1637D89-CCB7-4A68-B382-40B4BB9E50D7}"), NameTr = "Gemi+Sınırlı Zaman+ TIR ", NameEn = "Fast Vessel+Truck+Limited Time ", Enabled = true }

            );
    }
}


public class TransportRegionMethod
{
    public Guid RegionId { get; set; }
    public Guid MethodId { get; set; }
    public int Volume { get; set; }
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
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{C194434C-7A4D-4D70-98DF-1ECC78A333AA}"), MethodId = Guid.Parse("{730CD01E-FB25-4347-8932-2B4056252E73}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                //CANADA  
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{CBF432C2-FD9E-4618-9B8F-60BE075BEEF1}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{730CD01E-FB25-4347-8932-2B4056252E73}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{4F2FEBE8-3273-4086-89A4-0A0282F003A8}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{2ADD124B-9A78-4B78-96D1-523E658F77A4}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },      
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{AAAA0D64-ABD7-4E96-AA49-35D4253E014F}"), MethodId = Guid.Parse("{C1637D89-CCB7-4A68-B382-40B4BB9E50D7}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },

                //UK
                new TransportRegionMethod { RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{5D751653-BE94-44F4-AFBE-5BAF410AE321}"), MethodId = Guid.Parse("{AF3E3B1A-06D9-413F-99AD-3378458BE832}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                //Europe
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{7875CC3C-A338-480A-98D8-8D3296575000}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{96E1EF5B-916C-4885-AE5B-08A98541E92A}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{A5FE9692-EF46-4376-919F-43AEAA0C07A0}"), Volume = 6000, ETAMin = 3, ETAMax = 5 },
                new TransportRegionMethod { RegionId = Guid.Parse("{39887E51-8A46-42C1-B621-699D96326883}"), MethodId = Guid.Parse("{AF3E3B1A-06D9-413F-99AD-3378458BE832}"), Volume = 6000, ETAMin = 3, ETAMax = 5 }

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
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("7875CC3C-A338-480A-98D8-8D3296575000"), MinWeight = 0, MaxWeight = null, Value = 10m },

                //UK SEA
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 23, MaxWeight = 45, Value = 1.97m },
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 46, MaxWeight = 70, Value = 1.83m },
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 71, MaxWeight = 100, Value = 1.61m },
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 101, MaxWeight = 300, Value = 1.40m },
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 301, MaxWeight = 500, Value = 1.32m },
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 501, MaxWeight = 999, Value = 1.25m },
                //new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("C2A145A8-C7D9-4241-9D21-8BB4968C39CF"), MinWeight = 1000, MaxWeight = null, Value = 1.22m },

                //UK TRUCK
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 23, MaxWeight = 45, Value = 4.46m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 46, MaxWeight = 70, Value = 4.32m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 71, MaxWeight = 100, Value = 4.17m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 101, MaxWeight = 300, Value = 3.81m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 301, MaxWeight = 500, Value = 3.74m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 501, MaxWeight = 999, Value = 3.67m },
                new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{E7A610F5-1FE9-41E2-8493-34424D982B9B}"), MethodId = Guid.Parse("AF3E3B1A-06D9-413F-99AD-3378458BE832"), MinWeight = 1000, MaxWeight = null, Value = 3.64m },

                //CANADA AIR
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

                //CANADA SEA SLOW+ EXPRESS  

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

                 //CANADA SEA FAST+EXPRESS

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 23, MaxWeight = 45, Value = 2.66m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 46, MaxWeight = 70, Value = 2.09m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 71, MaxWeight = 100, Value = 2.01m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 101, MaxWeight = 300, Value = 1.94m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 301, MaxWeight = 500, Value = 1.87m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 501, MaxWeight = 999, Value = 1.80m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{573DA713-55B6-4505-9BB0-1E033F7C47E5}"), MethodId = Guid.Parse("CBF432C2-FD9E-4618-9B8F-60BE075BEEF1"), MinWeight = 1000, MaxWeight = null, Value = 1.77m },

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

                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 23, MaxWeight = 45, Value = 3.45m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 46, MaxWeight = 70, Value = 3.31m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 71, MaxWeight = 100, Value = 2.81m },
                 new TransportFee { Id = Guid.NewGuid(), DistrictId = Guid.Parse("{545149AD-862B-4E00-A5D6-E3492D68463B}"), MethodId = Guid.Parse("1EE2BA7B-97D2-4A3A-9B16-8B88563E91AD"), MinWeight = 101, MaxWeight = 300, Value =2.73m },
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