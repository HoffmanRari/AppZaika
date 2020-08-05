using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.ExpenseManagement;

namespace T_Zaika.Business.Service.ExpenseManagement
{
    public interface IExpenseManagementService
    {
        IEnumerable<ExpenseManagementDTO> GetAllExpenseManagements();
        ExpenseManagementDTO GetExpenseManagement(long id);
        void InsertExpenseManagement(ExpenseManagementDTO expenseManagementDto);
        void UpdateExpenseManagement(ExpenseManagementDTO expenseManagementDto);
        void DeleteExpenseManagement(long id);
    }
}
