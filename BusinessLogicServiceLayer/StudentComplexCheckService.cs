using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class StudentComplexCheckService : StudentCheckService // StudentCheckService ile bu sınıfa erişebilmek için kalıtım verdik.
    {
        // Eğer bu okul numarasına ve bu tc numarasına ait öğrenci varsa true değeri dönecek.
        public override Boolean checkStudent(BaseDAO baseDAO, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            return baseDAO.ogrenci_varMi_okulNo(ogrenci_okulNo) || baseDAO.ogrenci_varMi_tcNo(ogrenci_tcNo);
        }
    }
}
