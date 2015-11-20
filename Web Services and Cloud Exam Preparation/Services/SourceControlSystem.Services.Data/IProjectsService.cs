using SourceControlSystem.Common;
using SourceControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlSystem.Services.Data
{
    public interface IProjectsService
    {
        IQueryable<SoftwareProject> All(int page, int pageSize);

        int Add(string name, string description, string creator, bool isPrivate = false);
    }
}
