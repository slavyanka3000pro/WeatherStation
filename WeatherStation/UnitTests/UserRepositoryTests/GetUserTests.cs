using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UserRepositoryTests
{
    public class GetUserTests
    {
        [Fact]
        public void GetUser_ReturnsUserWithSuccess_WhenUserExistsInDatabase() {
            var options = new DbContextOptionsBu();
        }
        [Fact]
        public void GetUser_ReturnsNull_WhenUserDoesNotExistInDatabase()
        {
            
        }
    }
}
