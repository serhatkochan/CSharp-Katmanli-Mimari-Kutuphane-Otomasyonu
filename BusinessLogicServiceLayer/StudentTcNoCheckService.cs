using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class StudentTcNoCheckService : StudentCheckService // StudentCheckService ile bu sınıfa erişebilmek için kalıtım verdik.
    {
        // Eğer bu tcNo ya ait öğrenci varsa true değerini döndürecek.
        public override Boolean checkStudent(BaseDAO baseDAO, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            return baseDAO.ogrenci_varMi_tcNo(ogrenci_tcNo);
        }
    }
}
