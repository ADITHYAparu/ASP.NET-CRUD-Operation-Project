using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TaskManager.Models;

public partial class TaskTable
{
    public int Id { get; set; }
    [DisplayName("Name")]
    public string Name { get; set; } = null!;
    [DisplayName("Description")]
    public string Description { get; set; } = null!;
}
