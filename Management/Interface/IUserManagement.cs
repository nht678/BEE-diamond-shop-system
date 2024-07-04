using BusinessObjects.DTO;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace Management.Interface
{
    public interface IUserManagement
    {
        public Task<TokenResponseDto?> Login(LoginDto loginDto);
        //Bill
        public Task<IEnumerable<BillDetailDto?>?> GetBills();
        public Task<BillDetailDto?> GetBillById(int id);
        public Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto);
        //Crud User
        public Task<IEnumerable<UserDto?>?> GetUsers(int? roleId);
        public Task<User?> GetUserById(int id);
        public Task<int> AddUser(UserDto userDto);
        public Task<int> UpdateUser(int id, UserDto userDto);
        public Task<int> DeleteUser(int id);
    }
}
