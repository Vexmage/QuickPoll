using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class PollController : Controller
{
    private readonly ApplicationDbContext _context;

    public PollController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var polls = _context.Polls.Include(p => p.Options).ToList();
        return View(polls);
    }

    [HttpPost]
    public IActionResult Create(Poll poll, List<string> optionTexts)
    {
        if (ModelState.IsValid && optionTexts.Any())
        {
            foreach (var text in optionTexts)
            {
                poll.Options.Add(new PollOption { OptionText = text });
            }
            _context.Polls.Add(poll);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(poll);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var poll = _context.Polls.Include(p => p.Options).FirstOrDefault(p => p.Id == id); // Finds the poll by ID.
        if (poll != null)
        {
            _context.PollOptions.RemoveRange(poll.Options); // Delete related options
            _context.Polls.Remove(poll); // Delete poll itself
            _context.SaveChanges(); // Saves the changes to the database.
        }
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Vote(int optionId)
    {
        var option = _context.PollOptions.Find(optionId);
        if (option != null)
        {
            option.Votes++;
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
