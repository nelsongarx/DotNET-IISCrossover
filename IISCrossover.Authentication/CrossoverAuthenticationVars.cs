﻿namespace IISCrossover.Authentication
{
    public static class CrossoverAuthenticationVars
    {
        private const string _unique = "77a297cf-0651-4fb6-9c83-73a716e7a2f9";

        public static readonly string UserName = $"Crossover.UserName.{_unique}";
        public static readonly string Roles = $"Crossover.Roles.{_unique}";
    }
}
