using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class BorrowedDeleteCheckService : BorrowedCheckService // BorrowedCheckService ile bu sınıfa erişebilmek için kalıtım verdik.
    {
        // Kitap veya ogrenci silineceği zaman odunc tablosunda var mı diye kontrol sağlayacağımız kontrol servisi.
        public override Boolean borrowedCheck(BaseDAO baseDAO, int id, int tip)
        {
            if (tip == 1)
            {
                return baseDAO.odunc_kitap_varMi(id); // kitap varsa true yoksa false
            }
            else
            {
                return baseDAO.odunc_ogrenci_varMi(id); // öğrenci varsa true yoksa false
            }
        }
    }
}
