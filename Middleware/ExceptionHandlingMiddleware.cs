using PropEquityME_DOM;

namespace PropEquityME.Middleware
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        string[] staticPaths;
        public ExceptionHandlingMiddleware()
        {
            staticPaths = new[] { "b2cweb", "flash-banner", "fonts", "images", "INVESTORRELATIONS".ToLower(), "landingpage", "pagescripts", "scripts", "styles", ".ioc", ".js", ".png", ".jpg", ".css" };
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
                if (context.Response.StatusCode == 404)
                {
                    string path = context.Request.Path.ToString().ToLower().Trim();
                    var position = staticPaths.Select(x => path.IndexOf(x))
                    .Where(x => x > -1).DefaultIfEmpty(-1)
                    .FirstOrDefault();
                    Error error = new Error();
                    if (position == -1)
                    {
                        context.Response.Redirect($"/error/{context.Response.StatusCode}");
                        error.ErrorMessage = $"Invalid request '{path}.'";
                    }
                    else
                        error.ErrorMessage = $"Resource not found '{path}'.";

                    error.StatckTrace = "";
                    error.ErrorType = 404;
                    error.CrOn = DateTime.Now;
                    //CommonBAL objBal = new CommonBAL();
                    //await objBal.CreateErrorLog(error);

                }
            }
            catch (APIException ex)
            {
                //Error error = new Error();
                //error.ErrorMessage = ex.Message;
                //error.StatckTrace = ex.StackTrace ?? "";
                //error.CrOn = DateTime.Now;
                //CommonBAL objBal = new CommonBAL();
                //error.ErrorType = 500;
                //await objBal.CreateErrorLog(error);
                //string path = context.Request.Path.ToString().ToLower().Trim();
                //context.Response.Redirect($"/error/500");

                //context.Response.StatusCode = StatusCodes.Status404NotFound;
            }

            catch (NotFoundException ex)
            {
                //Error error = new Error();
                //error.ErrorMessage = ex.Message;
                //error.StatckTrace = ex.StackTrace ?? "";
                //error.CrOn = DateTime.Now;
                //CommonBAL objBal = new CommonBAL();
                //error.ErrorType = 500;
                //await objBal.CreateErrorLog(error);
                //string path = context.Request.Path.ToString().ToLower().Trim();

                //context.Response.Redirect($"{s}/error/500");

                //context.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            //catch (SqlException ex)
            //{
            //    Error error = new Error();
            //    error.ErrorMessage = ex.Message;
            //    error.StatckTrace = ex.StackTrace ?? "";
            //    error.CrOn = DateTime.Now;
            //    CommonBAL objBal = new CommonBAL();
            //    error.ErrorType = 500;
            //    await objBal.CreateErrorLog(error);
            //    string path = context.Request.Path.ToString().ToLower().Trim();
            //    context.Response.Redirect($"/error/500");
            //    //context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            //}
            catch (Exception ex)
            {
                //Error error = new Error();
                //error.ErrorMessage = ex.Message;
                //error.StatckTrace = ex.StackTrace ?? "";
                //error.CrOn = DateTime.Now;
                //CommonBAL objBal = new CommonBAL();
                //error.ErrorType = 500;
                //await objBal.CreateErrorLog(error);
                ////context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                //string path = context.Request.Path.ToString().ToLower().Trim();
                //context.Response.Redirect($"/error/500");
                //return "";
            }
        }
    }
}
