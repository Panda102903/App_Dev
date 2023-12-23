using AppDev.Models;
namespace BookShop1Asm.Interfaces
{
    public interface IRequest
    {
        List<RequestCategory> GetPending();
        List<RequestCategory> GetOfUser(string currentUserID);
        void Insert(RequestCategory request);
        void Update(RequestCategory request);
        //void Delete(Request category);
        RequestCategory GetById(int? id);
    }
}
