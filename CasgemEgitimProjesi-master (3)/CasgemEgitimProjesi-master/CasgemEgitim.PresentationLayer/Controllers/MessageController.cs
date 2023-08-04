using CasgemEgitim.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CasgemEgitim.PresentationLayer.Controllers
{
    public class MessageController:Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public ActionResult GetInboxTeacher()
        {
            var values = _messageService.GetInboxListByTeacher(2);
            return View(values);
        }
        public ActionResult MessageDetails(int id)
        {
            var values = _messageService.TGetById(id);
            ViewBag.subject = values.Subject;
            ViewBag.sender = values.SenderUser;
            ViewBag.message = values.MessageDetails;
            ViewBag.date = values.MessageDate;
            return View(values);
        }
    }
}
