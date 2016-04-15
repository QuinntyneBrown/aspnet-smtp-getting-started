using Chloe.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Chloe.Server.Controllers
{
    [RoutePrefix("api/notification")]
    public class NotificationController: ApiController
    {
        public NotificationController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        [Route("send")]
        [HttpGet]
        public IHttpActionResult Send() {
            this.notificationService.SendTestNotification();
            return Ok(); 
        }

        public INotificationService notificationService { get; set; }
    }
}