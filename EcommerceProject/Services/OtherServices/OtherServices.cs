namespace EcommerceProject.Services.OtherServices
{
    public class OtherServices : IOtherServices
    {
        public (bool, int) CheckIfInteger(string number)
        {
            try
            {
                int convNumber = Convert.ToInt32(number);
                return (true, convNumber);
            }
            catch
            {
            }
            return (false, 0);
        }
    }
}
