public class StoreSelectionViewModel
{
    public int Id { get; set; }
    public string TenCuaHang { get; set; }
    public bool IsSelected { get; set; }

    public override string ToString()
    {
        return TenCuaHang;
    }
}