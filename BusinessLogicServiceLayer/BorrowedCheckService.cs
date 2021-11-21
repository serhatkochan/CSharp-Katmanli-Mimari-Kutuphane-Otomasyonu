using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class BorrowedCheckService
    {
        ///////////// Ödünç ekleneceği, silineceği zaman vb. durumlarda Kontrol sağlayacağımız main class. // StudentCheckService gibi.
        public virtual Boolean borrowedCheck(BaseDAO baseDAO, int id, int tip)
        {
            return true;
        }
    }
}
