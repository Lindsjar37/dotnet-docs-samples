﻿// Copyright 2020 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// [START dlp_get_job]

using Google.Cloud.Dlp.V2;
using System;

public class JobsGet
{
    public static DlpJob GetDlpJob(string jobName)
    {
        var dlp = DlpServiceClient.Create();

        var response = dlp.GetDlpJob(jobName);

        Console.WriteLine($"Job: {response.Name} status: {response.State}");

        return response;
    }
}

// [END dlp_get_job]
