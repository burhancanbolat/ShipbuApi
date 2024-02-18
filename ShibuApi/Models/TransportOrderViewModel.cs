namespace ShipbuApi.Models;


public class TransportOrderViewModel
{
    public List<Item> Items { get; set; }
    public Guid Destination { get; set; }
    public Guid Origin { get; set; }
    public TransportOrderDistrict District { get; set; }
}

public class ContainerType
{
    public Guid Id { get; set; }
}

public class Feature
{
    public Guid Id { get; set; }
    public decimal Fee { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }

    //public string? attachment { get; set; }
    //public string? attachmentFileName { get; set; }
}
public class TransportOrderDistrict
{
    public Guid Id { get; set; }
}

public class Item
{
    public decimal Quantity { get; set; }
    public decimal Weight { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public decimal? Length { get; set; }
    public string Contents { get; set; }
    public decimal? Products { get; set; }
    public List<Feature> Features { get; set; }
    public string Image { get; set; }
    public decimal Amount { get; set; }
    public ContainerType? ContainerType { get; set; }
    public TransportOrderItemType Type { get; set; }
}


public class TransportOrderItemType
{
    public int Id { get; set; }
}

