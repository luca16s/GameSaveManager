﻿namespace GameSaveManager.Core.Services
{
    using GameSaveManager.Core.Enums;
    using GameSaveManager.Core.Interfaces;
    using GameSaveManager.Core.Utils;

    using System;

    public class BackupFactory : IFactory<IBackupStrategy>
    {
        public IBackupStrategy Create(EBackupSaveType saveType)
        {
            return saveType switch
            {
                EBackupSaveType.BakFile => new BakBackupStrategy(),
                EBackupSaveType.ZipFile => new ZipBackupStrategy(),
                _ => throw new InvalidOperationException(SystemMessages.ErrorFileNotSupported),
            };
        }
    }
}