using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class BookAllCheckService : BookCheckService // BookCheckService ile bu sınıfa erişebilmek için kalıtım verdik.
    {
        // Kitap eklenirken bu kitabın bütün parametrelerini kontrol edip hepsi uyuşuyorsa True değerini döndürecek.
        public override Boolean checkBook(BaseDAO baseDAO, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi)
        {
            return baseDAO.kitap_varMi(kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi);
        } 
    }
}
