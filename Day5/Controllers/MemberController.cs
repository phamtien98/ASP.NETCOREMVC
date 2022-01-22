using Microsoft.AspNetCore.Mvc;
using Day5.Services;
using Day5.Models;
using System.Data;
using ClosedXML.Excel;

namespace Day5.Controllers
{

    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly ILogger<MemberController> _logger;
        public MemberController(ILogger<MemberController> logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
        }

        public IActionResult GetAllPeople() {
            return Ok(_memberService.GetAllPeople());
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Error();
        }

        public IActionResult MaleMembers()
        {
            return Ok(_memberService.GetMaleMembers());
        }

        public IActionResult OldestMember()
        {
            return Ok(_memberService.OldestMember());
        }

        public IActionResult GetMemberByYear(int year)
        {
            return Ok(_memberService.GetMemberByYear(year));
        }

        public FileResult ExporttExcelFile()
        {
            var table = _memberService.GetData();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(table, "People Information");
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "PepoleInfo.xlsx");
                }
            }
        }

        public IActionResult FullNames()
        {
            return Ok(_memberService.FullNames());
        }
    }
}