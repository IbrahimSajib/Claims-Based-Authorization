using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Claims_Based_Authorization.Models
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
     

            //PasswordHasher
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            //Creating User
            var user1 = new IdentityUser
            {
                Id = "b96a4ff1-c4ec-40e6-9496-d45fd45085c1",
                UserName = "Admin1@abc.com",
                NormalizedUserName = "ADMIN1@ABC.COM",
                Email = "Admin1@abc.com",
                NormalizedEmail = "ADMIN1@ABC.COM",
            };
            user1.PasswordHash = ph.HashPassword(user1, "Admin1@abc.com"); //Set user password

            var user2 = new IdentityUser
            {
                Id = "b6798a21-75db-46c5-b696-b47387c450f0",
                UserName = "HR1@abc.com",
                NormalizedUserName = "HR1@ABC.COM",
                Email = "HR1@abc.com",
                NormalizedEmail = "HR1@ABC.COM",
            };
            user2.PasswordHash = ph.HashPassword(user2, "HR1@abc.com");

            var user3 = new IdentityUser
            {
                Id = "b7f46612-41d2-47ba-af30-f957a680d92a",
                UserName = "Ibrahim@example.com",
                NormalizedUserName = "IBRAHIM@EXAMPLE.COM",
                Email = "Ibrahim@example.com",
                NormalizedEmail = "IBRAHIM@EXAMPLE.COM",
            };
            user3.PasswordHash = ph.HashPassword(user3, "Ibrahim1@example.com");

            var user4 = new IdentityUser
            {
                Id = "0442b285-375d-48a0-8f47-d6e21bf342c9",
                UserName = "Sajib@example.com",
                NormalizedUserName = "SAJIB@EXAMPLE.COM",
                Email = "Sajib@example.com",
                NormalizedEmail = "SAJIB@EXAMPLE.COM",
            };
            user4.PasswordHash = ph.HashPassword(user4, "Sajib1@example.com");
            
            var user5 = new IdentityUser
            {
                Id = "176429b6-a988-40f6-825a-d1eed4e0eeb5",
                UserName = "Male1@abc.com",
                NormalizedUserName = "MALE1@ABC.COM",
                Email = "Male1@abc.com",
                NormalizedEmail = "MALE1@ABC.COM",
            };
            user5.PasswordHash = ph.HashPassword(user5, "Male1@abc.com");
            
            var user6 = new IdentityUser
            {
                Id = "fc6937ab-d96b-4c2e-88a2-3de1afd319a1",
                UserName = "Female1@abc.com",
                NormalizedUserName = "FEMALE1@ABC.COM",
                Email = "Female1@abc.com",
                NormalizedEmail = "FEMALE1@ABC.COM",
            };
            user6.PasswordHash = ph.HashPassword(user6, "Female1@abc.com");
            
            var user7 = new IdentityUser
            {
                Id = "01cf226c-9a88-4109-bd93-af54a6d53964",
                UserName = "Bangladeshi1@abc.com",
                NormalizedUserName = "BANGLADESHI1@ABC.COM",
                Email = "Bangladeshi1@abc.com",
                NormalizedEmail = "BANGLADESHI1@ABC.COM",
            };
            user7.PasswordHash = ph.HashPassword(user7, "Bangladeshi1@abc.com");
            

            var user8 = new IdentityUser
            {
                Id = "620b2b39-426e-42e1-8ca8-82551f11acc0",
                UserName = "Japanese1@abc.com",
                NormalizedUserName = "JAPANESE1@ABC.COM",
                Email = "Japanese1@abc.com",
                NormalizedEmail = "JAPANESE1@ABC.COM",
            };
            user8.PasswordHash = ph.HashPassword(user8, "Japanese1@abc.com");


            
            var user9 = new IdentityUser
            {
                Id = "75293121-df2d-4e4b-abf1-a1ef0e7e4d0b",
                UserName = "Australians1@abc.com",
                NormalizedUserName = "AUSTRALIANS1@ABC.COM",
                Email = "Australians1@abc.com",
                NormalizedEmail = "AUSTRALIANS1@ABC.COM",
            };
            user9.PasswordHash = ph.HashPassword(user9, "Australians1@abc.com");


            
            var user10 = new IdentityUser
            {
                Id = "9702702f-df96-44e0-aad8-0222b618ed8f",
                UserName = "Canadian1@abc.com",
                NormalizedUserName = "CANADIAN1@ABC.COM",
                Email = "Canadian1@abc.com",
                NormalizedEmail = "CANADIAN1@ABC.COM",
            };
            user10.PasswordHash = ph.HashPassword(user10, "Canadian1@abc.com");
            
            var user11 = new IdentityUser
            {
                Id = "c02f71c8-a822-4b3a-900c-5c62478b32f0",
                UserName = "Admin1@gmail.com",
                NormalizedUserName = "ADMIN1@GMAIL.COM",
                Email = "Admin1@gmail.com",
                NormalizedEmail = "ADMIN1@GMAIL.COM",
            };
            user11.PasswordHash = ph.HashPassword(user11, "Admin1@gmail.com");

            //Seed User
            builder.Entity<IdentityUser>().HasData(user1, user2, user3, user4, user5, user6, user7, user8, user9, user10, user11);



            //Seed User Claims
            builder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = "b96a4ff1-c4ec-40e6-9496-d45fd45085c1",
                    ClaimType = "Role",
                    ClaimValue = "Admin"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = "b6798a21-75db-46c5-b696-b47387c450f0",
                    ClaimType = "Role",
                    ClaimValue = "HR"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 3,
                    UserId = "b7f46612-41d2-47ba-af30-f957a680d92a",
                    ClaimType = "Role",
                    ClaimValue = "Admin"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 4,
                    UserId = "0442b285-375d-48a0-8f47-d6e21bf342c9",
                    ClaimType = "Role",
                    ClaimValue = "Admin"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 5,
                    UserId = "176429b6-a988-40f6-825a-d1eed4e0eeb5",
                    ClaimType = "Gender",
                    ClaimValue = "Male"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 6,
                    UserId = "fc6937ab-d96b-4c2e-88a2-3de1afd319a1",
                    ClaimType = "Gender",
                    ClaimValue = "Female"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 7,
                    UserId = "01cf226c-9a88-4109-bd93-af54a6d53964",
                    ClaimType = "Country",
                    ClaimValue = "Bangladesh"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 8,
                    UserId = "620b2b39-426e-42e1-8ca8-82551f11acc0",
                    ClaimType = "Country",
                    ClaimValue = "Japan"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 9,
                    UserId = "75293121-df2d-4e4b-abf1-a1ef0e7e4d0b",
                    ClaimType = "Country",
                    ClaimValue = "Australia"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 10,
                    UserId = "9702702f-df96-44e0-aad8-0222b618ed8f",
                    ClaimType = "Country",
                    ClaimValue = "Canada"
                },
               
                new IdentityUserClaim<string>
                {
                    Id = 11,
                    UserId = "c02f71c8-a822-4b3a-900c-5c62478b32f0",
                    ClaimType = "Role",
                    ClaimValue = "Admin"
                }                   
                );

        }
    }
}
