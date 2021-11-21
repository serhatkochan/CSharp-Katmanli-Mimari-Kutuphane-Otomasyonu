using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class StudentCheckService
    {
        ///////////// Öğrenci ekleneceği zaman vb. durumlarda Kontrol sağlayacağımız main class. // BaseDAO gibi.
        public virtual Boolean checkStudent(BaseDAO baseDAO, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            return true;
        }
    }
}
   