namespace JD.Invoicing.Roles.Dto
{
    public class FlatPermissionDto
    {
        public long ParentID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}