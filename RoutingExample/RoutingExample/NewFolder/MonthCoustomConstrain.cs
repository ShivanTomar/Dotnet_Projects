
using System.Text.RegularExpressions;

namespace RoutingExample.NewFolder
{
    public class MonthCoustomConstrain : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
           // throw new NotImplementedException();
           //check whether the value exists
           if(!values.ContainsKey(routeKey)) return false;

            Regex regex = new Regex("^(apr|jul|oct|jan)$");
            string? monthvalue = Convert.ToString(values[routeKey]);

            if(regex.IsMatch(monthvalue)) return true;

            return false;
        }
    }
}
