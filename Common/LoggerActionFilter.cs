using Microsoft.AspNetCore.Mvc.Filters;

namespace PropEquityME.Common
{
    public class LoggerActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.HttpContext.Request.Method == "GET")
            {
                //CommonBAL commonBAL = new CommonBAL();

                //UserVisitLog userVisitLog = new UserVisitLog();
                //userVisitLog.Path = context.HttpContext.Request.Path.ToString();
                //if (!context.HttpContext.Session.HasSession("UserVisitLogId"))
                //{
                //    //context.HttpContext.Request.RouteValues
                //    if (context.HttpContext.Request.Query.Count() > 0)
                //    {
                //        userVisitLog.QueryString = context.HttpContext.Request.QueryString.Value.ToString();

                //        userVisitLog.Source = context.HttpContext.Request.Query["source"].ToString();
                //        userVisitLog.Content = context.HttpContext.Request.Query["content"].ToString();
                //        userVisitLog.Medium = context.HttpContext.Request.Query["medium"].ToString();
                //        userVisitLog.Campaign = context.HttpContext.Request.Query["campaign"].ToString();

                //    }

                //    if (context.HttpContext.Request.RouteValues["utmid"] != null)
                //        userVisitLog.UTMId = context.HttpContext.Request.RouteValues["utmid"].ToString();

                //    userVisitLog.IpAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
                //    userVisitLog.SessionId = context.HttpContext.Session.Id;
                //    Int64 LogId = await commonBAL.SaveUserVisitLog(userVisitLog, DateTime.Now);
                //    context.HttpContext.Session.SetSession<Int64>("UserVisitLogId", LogId);
                //}

                //if (context.HttpContext.Session.HasSession("UserVisitLogId"))
                //{
                //    userVisitLog.VisitLogId = context.HttpContext.Session.GetSession<Int64>("UserVisitLogId");
                //    await commonBAL.SaveUserPageVisitLog(userVisitLog, DateTime.Now);
                //}
            }
            await next();
        }
    }
}
