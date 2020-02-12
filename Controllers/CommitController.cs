namespace RokonoControl.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;
    using RokonoControl.Models;

    public class CommitController : Controller
    {

        RokonoControlContext Context;
        public CommitController(RokonoControlContext context)
        {
            Context = context;
        }
        public IActionResult Index(int projectId)
        {
            var currentUser = this.User;
            var id = currentUser.Claims.ElementAt(1);

            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            using (var context = new DatabaseController(Context))
            {
                ViewData["Projects"] = context.GetUserProjects(int.Parse(id.Value));

                ViewData["Relationships"] = context.GetProjectRelationships();
                ViewData["Branches"] = context.GetBranchesForProject(projectId);
                ViewData["DefaultIteration"] = context.GetProjectDefautIteration(projectId);

            }
            return View();
        }


        public IActionResult CommitData(string commitId, int projectId, int branchId)
        {
            var currentUser = this.User;
            var rights = currentUser.Claims.LastOrDefault().Value;
            var id = currentUser.Claims.ElementAt(1);

            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            ViewData["CommitKey"] = commitId;
            ViewData["BranchId"] = branchId;
            ViewData["ProjectId"] = projectId;
            using (var context = new DatabaseController(Context))
            {
                ViewData["Projects"] = context.GetUserProjects(int.Parse(id.Value));

                ViewData["Relationships"] = context.GetProjectRelationships();
                ViewData["DefaultIteration"] = context.GetProjectDefautIteration(projectId);

            }
            return View();
        }
        public IActionResult Files(int projectId)
        {
            var currentUser = this.User;
            var id = currentUser.Claims.ElementAt(1);

            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            ViewData["ProjectId"] = projectId;
            using (var context = new DatabaseController(Context))
            {
                ViewData["Projects"] = context.GetUserProjects(int.Parse(id.Value));

                ViewData["Relationships"] = context.GetProjectRelationships();
                var bindingBranches = context.GetProjectBranches(projectId);
                if (bindingBranches != null)
                {
                    ViewData["BranchId"] = bindingBranches.FirstOrDefault(x => x.BranchName == "master").Id;
                    ViewData["Branches"] = bindingBranches;
                    ViewData["DefaultIteration"] = context.GetProjectDefautIteration(projectId);

                }
                else
                    return View(new ClientErrorData { Title = "Invalid data result, please supply proper Project Id or contact your system administrator." });
            }
            return View();

        }

        [HttpGet]
        public List<OutgoingCommitData> GetCommits(int projectId, int branchId)
        {
            var data = new List<OutgoingCommitData>();
            using (var context = new DatabaseController(Context))
            {
                if (branchId != 0)
                    data = context.GetCommitData(projectId, branchId);
                else
                    data = context.GetCommitDataMaster(projectId);
            }
            return data;
        }

        [HttpGet]
        public List<CommitFileHirarhicalData> GetCommitFiles(string commitId)
        {
            var data = new List<CommitFileHirarhicalData>();
            using (var context = new DatabaseController(Context))
            {
                data = context.GetCommitFilesHirarchy(commitId);
            }
            return data;
        }

        [HttpGet]
        public OutgoingSourceFile GetCommitFileData(int fileId, int branch)
        {
            var result = default(OutgoingSourceFile);
            using (var context = new DatabaseController(Context))
            {
                result = context.GetSelectedFileById(fileId, branch);
            }
            return result;
        }
        [HttpGet]
        public List<CommitFileHirarhicalData> GetBranchFiles(int projectId, int branchId)
        {
            var result = new List<CommitFileHirarhicalData>();
            using (var context = new DatabaseController(Context))
            {
                var getProject = context.GetBranchFiles(projectId, branchId);
                if (getProject != null)
                    result = context.GetFileHirarchy(getProject);
            }
            return result;
        }

        [HttpGet]
        public OutgoingSourceFile GetSelectedFile(string fileName, int projectId, int branch)
        {
            var result = default(OutgoingSourceFile);
            using (var context = new DatabaseController(Context))
            {
                result = context.GetSelectedFileByName(fileName, projectId, branch);
            }
            return result;
        }
    }
}