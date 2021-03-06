// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Runtime.InteropServices;
using Xunit;

public class GetEnvironmentVariable
{
    [Fact]
    public void NullVariableThrowsArgumentNull()
    {
        Assert.Throws<ArgumentNullException>(() => Environment.GetEnvironmentVariable(null));
    }

    [Fact]
    public void EmptyVariableReturnsNull()
    {
        Assert.Equal(null, Environment.GetEnvironmentVariable(String.Empty));
    }

    [Fact]
    public void RandomLongVariableNameCanRoundTrip()
    {
        // NOTE: The limit of 32766 characters enforced by dekstop
        // SetEnvironmentVariable (not in the contract) is antiquated. I was
        // able to create ~1GB names and values on my Windows 8.1 box. On
        // desktop, GetEnvironmentVariable throws OOM during its attempt to
        // demand huge EnvironmentPermission well before that. Also, the old
        // test for long name case wasn't very good: it just checked that an
        // arbitrary long name > 32766 characters returned null (not found), but
        // that had nothing to do with the limit, the variable was simply not
        // found!

        string variable = "LongVariable_" + new string('@', 33000);
        const string value = "TestValue";

        try
        {
            Assert.Equal(true, SetEnvironmentVariable(variable, value));

            Assert.Equal(value, Environment.GetEnvironmentVariable(variable));
        }
        finally
        {
            Assert.Equal(true, SetEnvironmentVariable(variable, null));
        }
    }

    [Fact]
    public void RandomVariableThatDoesNotExistReturnsNull()
    {
        string variable = "TestVariable_SurelyThisDoesNotExist";
        Assert.Equal(null, Environment.GetEnvironmentVariable(variable));
    }

    [Fact]
    public void VariableNamesAreCaseInsensitive()
    {
        const string value = "TestValue";

        try
        {
            Assert.Equal(true, SetEnvironmentVariable("ThisIsATestEnvironmentVariable", value));

            Assert.Equal(value, Environment.GetEnvironmentVariable("ThisIsATestEnvironmentVariable"));
            Assert.Equal(value, Environment.GetEnvironmentVariable("thisisatestenvironmentvariable"));
            Assert.Equal(value, Environment.GetEnvironmentVariable("THISISATESTENVIRONMENTVARIABLE"));
            Assert.Equal(value, Environment.GetEnvironmentVariable("ThISISATeSTENVIRoNMEnTVaRIABLE"));
        }
        finally
        {
            Assert.Equal(true, SetEnvironmentVariable("ThisIsATestEnvironmentVariable", null));
        }
    }

    [Fact]
    public void CanGetAllVariablesIndividually()
    {
        Random r = new Random();
        string envVar1 = "TestVariable_CanGetVariablesIndividually_" + r.Next().ToString();
        string envVar2 = "TestVariable_CanGetVariablesIndividually_" + r.Next().ToString();

        try
        {
            Environment.SetEnvironmentVariable(envVar1, envVar1);
            Environment.SetEnvironmentVariable(envVar2, envVar2);

            IDictionary envBlock = Environment.GetEnvironmentVariables();

            // Make sure the environment variables we set are part of the dictionary returned.
            Assert.True(envBlock.Contains(envVar1));
            Assert.True(envBlock.Contains(envVar1));

            // Make sure the values match the expected ones.
            Assert.Equal(envVar1, envBlock[envVar1]);
            Assert.Equal(envVar2, envBlock[envVar2]);

            // Make sure we can read the individual variables as well
            Assert.Equal(envVar1, Environment.GetEnvironmentVariable(envVar1));
            Assert.Equal(envVar2, Environment.GetEnvironmentVariable(envVar2));
        }
        finally
        {
            // Clear the variables we just set
            Environment.SetEnvironmentVariable(envVar1, null);
            Environment.SetEnvironmentVariable(envVar2, null);
        }
    }

    [DllImport("api-ms-win-core-processenvironment-l1-1-0.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern bool SetEnvironmentVariable(string lpName, string lpValue);
}
