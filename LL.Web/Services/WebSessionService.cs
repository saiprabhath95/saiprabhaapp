using LL.Web.Models;
using System.Threading.Tasks;

namespace LL.Web.Services
{
    public class WebSessionServices : IWebSessionServices
    {
        public WebSessionServices()
        {
        }

        public async Task<double> ComputeUserSession(ViewModel.WebSessionItem items)
        {
            double normValue = 0;
            using (AB_Prabha_DBContext context = new AB_Prabha_DBContext())
            {
                double normlastActiveNorm = ((50 - items.lastActive) / 50.0) * 3;
                double timeNorm = ((items.sessions) / 50.0) * 2;
                double sessionDurNorm = ((items.sessionDuration) / 50.0) * 2;
                double clicksNorm = ((items.clicks) / 50.0) / 50.0;
                double mailOffenderNorm = (50 - items.mailOffender) / 50.0;
                double notSpammedNorm = (50 - items.notSpammed) / 50.0;

                normValue = normlastActiveNorm + timeNorm 
                    + sessionDurNorm + clicksNorm 
                    + mailOffenderNorm + notSpammedNorm;
            }
            return normValue;
        }
    }
}
