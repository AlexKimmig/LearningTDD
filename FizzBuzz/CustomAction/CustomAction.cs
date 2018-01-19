using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;

namespace CustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomActionMethod(Session session)
        {
            try
            {
                session.Log("Beginning CustomAction1");

                session.Log("Ending CustomAction1");
            }
            catch (Exception ex)
            {
                session.Log("ERROR in CustomAction1r {0}", ex.ToString());
                return ActionResult.Failure;
            }
            return ActionResult.Success;
        }
    }
}
