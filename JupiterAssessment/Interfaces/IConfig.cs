using JupiterAssessment.Configuration;

namespace JupiterAssessment.Interfaces
{
    public interface IConfig
    {
       BrowserType GetBrowser();

        string GetWebsite();

        int GetPageLoadTimeOut();

        int GetElementLoadTimeout();




    }
}
