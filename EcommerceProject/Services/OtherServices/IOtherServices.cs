namespace EcommerceProject.Services.OtherServices
{
    public interface IOtherServices
    {
        (bool, int) CheckIfInteger(string number);
    }
}
