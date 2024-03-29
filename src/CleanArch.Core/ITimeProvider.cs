// Copyright (c) Hibex Solutions. All rights reserved.
// This file is a part of CleanArch.
// Licensed under the Apache version 2.0: LICENSE file.

namespace CleanArch.Core;

/// <summary>
/// Provedor de tempo
/// </summary>
public interface ITimeProvider
{
    /// <summary>
    /// Obtém a data e hora UTC (Tempo Universal Coordenado) atual
    /// </summary>
    /// <returns>Data/hora atual</returns>
    DateTimeOffset GetUtcNow();
}