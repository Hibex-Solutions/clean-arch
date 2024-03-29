// Copyright (c) Hibex Solutions. All rights reserved.
// This file is a part of CleanArch.
// Licensed under the Apache version 2.0: LICENSE file.

namespace CleanArch.Core;

public class DefaultTimeProvider : ITimeProvider
{
    /// <summary>
    /// Obtém a data e hora UTC (Tempo Universal Coordenado) atual
    /// </summary>
    /// <returns>Data/hora atual</returns>
    public DateTimeOffset GetUtcNow() => DateTime.UtcNow;
}