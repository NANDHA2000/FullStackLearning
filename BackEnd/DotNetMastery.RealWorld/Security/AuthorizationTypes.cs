using System.Security.Claims;

namespace DotNetMastery.RealWorld.Security
{
    public static class AuthorizationTypes
    {
        #region 1. Simple Authenticated User Check
        // Checks only if the user is authenticated, regardless of roles or permissions
        public static bool IsAuthenticated(ClaimsPrincipal principal)
        {
            return principal.Identity?.IsAuthenticated ?? false;
        }
        #endregion

        #region 2. Role-Based Authorization (RBAC)
        // Access is granted based on predefined roles (e.g., Admin, User, Manager)
        public static bool AuthorizeRole(ClaimsPrincipal principal, string requiredRole)
        {
            return principal.IsInRole(requiredRole);
        }
        #endregion

        #region 3. Claims-Based Authorization
        // Access is granted based on specific key-value pairs (Claims) attached to the identity
        // Flexible: Doesn't depend on broad roles
        public static bool AuthorizeClaim(ClaimsPrincipal principal, string claimType, string requiredValue)
        {
            return principal.HasClaim(c => c.Type == claimType && c.Value == requiredValue);
        }
        #endregion

        #region 4. Policy-Based Authorization
        // Evaluates complex rules and multiple claims combined (e.g., must be in Engineering AND 18+ years old)
        public static bool EvaluateEngineeringPolicy(ClaimsPrincipal principal)
        {
            bool hasDept = principal.HasClaim("Department", "Engineering");
            bool isPrivileged = principal.IsInRole("Admin") || principal.IsInRole("Lead");

            return hasDept && isPrivileged;
        }
        #endregion

        #region 5. Resource-Based Authorization
        // Evaluates whether a user has permission to access or modify a SPECIFIC data item
        // e.g., A regular author can only edit their own book, while an Admin can edit any book
        public class ResourceBook
        {
            public int BookId { get; set; }
            public string Title { get; set; } = string.Empty;
            public string OwnerUserId { get; set; } = string.Empty;
        }

        public static bool CanEditBook(ClaimsPrincipal principal, ResourceBook book)
        {
            // Admins can edit any book
            if (principal.IsInRole("Admin"))
            {
                return true;
            }

            // Normal users can only edit their own book
            string? currentUserId = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return currentUserId != null && currentUserId == book.OwnerUserId;
        }
        #endregion
    }
}