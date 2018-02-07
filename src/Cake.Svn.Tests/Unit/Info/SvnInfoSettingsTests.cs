﻿using Cake.Svn.Info;
using Xunit;

namespace Cake.Svn.Tests.Unit.Info
{
    public sealed class SvnInfoSettingsTests
    {
        public sealed class TheConstructor
        {
            [Fact]
            public void Should_Set_Empty_Depth_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.Equal(SvnDepth.Empty, settings.Depth);
            }

            [Fact]
            public void Should_RetrieveActualOnly_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.True(settings.RetrieveActualOnly);
            }

            [Fact]
            public void Should_RetrieveExcluded_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.True(settings.RetrieveExcluded);
            }

            [Fact]
            public void Should_Not_IncludeExternals_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.False(settings.IncludeExternals);
            }

            [Fact]
            public void Should_Set_Revision_To_Null_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.Null(settings.Revision);
            }

            [Fact]
            public void Should_Set_ThrowOnCancel_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.True(settings.ThrowOnCancel);
            }

            [Fact]
            public void Should_Set_ThrowOnError_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.True(settings.ThrowOnError);
            }

            [Fact]
            public void Should_Set_ThrowOnWarning_By_Default()
            {
                // Given, When
                var settings = new SvnInfoSettings();

                // Then
                Assert.False(settings.ThrowOnWarning);
            }
        }
    }
}
