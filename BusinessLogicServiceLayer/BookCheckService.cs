using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class BookCheckService
    {
        ///////////// Kitap ekleneceği zaman vb. durumlarda Kontrol sağlayacağımız main class. // StudentCheckService gibi.
        public virtual Boolean checkBook(BaseDAO baseDAO, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi)
        {
            return true;
        }

    }
}
