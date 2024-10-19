namespace RentalCar.User.Application.Queries.Response.Roles
{
    public class FindRoleResponse(string Id, string Name)
    {
        public string Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        //public string CreateAt { get; set; } = CreateAt;
    }
}
