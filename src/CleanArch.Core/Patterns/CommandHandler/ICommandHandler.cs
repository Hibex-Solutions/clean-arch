// Copyright (c) Hibex Solutions. All rights reserved.
// This file is a part of CleanArch.
// Licensed under the Apache version 2.0: LICENSE file.

namespace CleanArch.Core;

/// <summary>
/// Um manipulador de comando
/// </summary>
public interface ICommandHandler
{
    Task HandleAsync(object command);
}