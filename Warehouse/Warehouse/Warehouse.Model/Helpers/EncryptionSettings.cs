﻿namespace Warehouse.Model.Helpers
{
    public sealed class EncryptionSettings
    {
        public int PasswordHashLength { get; init; }
        public int SaltLength { get; init; }
        public int HashIterationsCount { get; init; }
    }
}
