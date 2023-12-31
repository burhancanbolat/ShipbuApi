using ShipbuData;

namespace ShipbuApi.Models.Data;

public class TransportOrderItemFeatureViewModel
{
    public bool Enabled { get; set; }
    public FeatureAttachmentType Type { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }
    public string DescriptionTr { get; set; }
    public string DescriptionEn { get; set; }
    public int DisplayOrder { get; set; }
    public string? AttachmentDescriptionTr { get; set; }
    public string? AttachmentDescriptionEn { get; set; }
}
