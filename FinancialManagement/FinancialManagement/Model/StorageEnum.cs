using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagement.Model
{
    enum StorageEnum
    {
        Unknown_Error = 0,
        Success =1,
        Storage_Have_Capacity =2,
        Storage_Not_Found =3,
        Storage_Cant_Duplicate = 4,
        Storage_Maxcapacity_Not_Enough = 5
    }
}
