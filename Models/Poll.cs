using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Poll
{
    public int Id { get; set; }

    [Required]
    public string Question { get; set; }

    public List<PollOption> Options { get; set; } = new();
}

public class PollOption
{
    public int Id { get; set; }

    [Required]
    public string OptionText { get; set; }

    public int Votes { get; set; } = 0;

    public int PollId { get; set; }
}
