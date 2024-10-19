namespace RentalCar.User.Application.Commands.Response.Roles
{
    public class InputRoleResponse(string Id, string Name)
    {
        public string Id { get; set; } = Id;
        public string Name { get; set; } = Name;
    }
}
