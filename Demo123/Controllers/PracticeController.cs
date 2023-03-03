using Demo123.Data;
using Demo123.DTO;
using Demo123.Models.Domain;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Demo123.Controllers
{
    public class PracticeController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public PracticeController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = new PracticeDto();
            result.Result1 = await mvcDemoDbContext.Job.ToListAsync();
            result.Result2 = await mvcDemoDbContext.Suppiler.ToListAsync();
            result.Result3 = await mvcDemoDbContext.Part.ToListAsync();
            result.Result4 = await mvcDemoDbContext.Part.Where(x => x.color.Equals("red")).ToListAsync();
            //result.Result5 = await mvcDemoDbContext.Part.ToArrayAsync();
            result.Result6 = await mvcDemoDbContext.Part.Where(x => x.color.Equals("green")).ToListAsync();
            result.Result7 = await mvcDemoDbContext.Job.ToListAsync();
            result.Result8 = await mvcDemoDbContext.Job.Where(x => x.city.Equals("Paris")).ToListAsync();
            result.Result9 = await mvcDemoDbContext.Spj.Where(x => x.jno.Equals("J1")).ToListAsync();
            result.Result10 = await mvcDemoDbContext.Spj.Where(x => x.jno.Equals("J3") && x.pno.Equals("P6")).ToListAsync();
            result.Result11 = await mvcDemoDbContext.Part.Where(x => x.weight>=17).ToListAsync();
            result.Result12 = await mvcDemoDbContext.Job.Where(x => x.city!=("Paris")&& x.city!=("London")).ToListAsync();
            result.Result26 = await mvcDemoDbContext.Part.Where(x => x.pname.StartsWith("C")).ToListAsync();
            //result.Result27 = await mvcDemoDbContext.Suppiler.Where(x => x.sname.Re("__a")).ToListAsync();
            result.Result13 = await (from item in mvcDemoDbContext.Spj
                                    join part in mvcDemoDbContext.Part
                                    on item.pno equals part.pno
                                    select new viewModel
                                    {
                                        pname = part.pname,
                                        qty = item.qty
                                    }).ToListAsync();
            result.Result14 = await (from sup in mvcDemoDbContext.Suppiler
                                     join spj in mvcDemoDbContext.Spj
                                        on sup.sno equals spj.sno
                                     join jobs in mvcDemoDbContext.Job
                                        on spj.jno equals jobs.jno
                                     select new viewModel14
                                     {
                                         city = jobs.city,
                                         job= sup.city,

                                     }).ToListAsync();
            result.Result15 = await (from spj in mvcDemoDbContext.Spj
                                     join sup in mvcDemoDbContext.Suppiler
                                        on spj.sno equals sup.sno
                                     join part in mvcDemoDbContext.Part
                                        on spj.pno equals part.pno
                                    join job in mvcDemoDbContext.Job
                                        on spj.jno equals job.jno
                                     select new viewModel15
                                     {
                                         job = sup.city,
                                        
                                         pno = part.pno,
                                         city = job.city


                                     }).ToListAsync();
            result.Result16 = await (from a in mvcDemoDbContext.Suppiler
                                     from b in mvcDemoDbContext.Suppiler
                                     where a.city == b.city &&
                                     a.sno.CompareTo(b.sno) <0
                                     select new viewModel16 { sno = a.sno, sno1 = b.sno }).ToListAsync();
            result.Result20 = await (from a in mvcDemoDbContext.Spj
                                     join b in mvcDemoDbContext.Job
                                     on a.jno equals b.jno
                                     where a.sno.Equals("S1")
                                     select new viewModel20
                                     {
                                         jname = b.jname
                                     }).ToListAsync();
            result.Result35 = await (from a in mvcDemoDbContext.Part
                                    orderby a.weight descending
                                    select a).ToListAsync();
         




















            return View(result);


        }
        
}
}
