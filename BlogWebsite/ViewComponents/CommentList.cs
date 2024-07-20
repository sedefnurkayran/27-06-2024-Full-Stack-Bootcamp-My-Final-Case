using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents
{

    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>{

                new UserComment{

                   UserCommentId=1,
                    UserName="Sedef"
                },
                    new UserComment{

                   UserCommentId=2,
                    UserName="Fatih"
                },
                    new UserComment{

                   UserCommentId=3,
                    UserName="Sefa"
                },
            };

            return View(values);
        }

    }
}