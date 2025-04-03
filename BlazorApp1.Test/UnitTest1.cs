using Bunit;
using Xunit;
using BlazorApp1.Components.Layout;

public class NavMenuTests : TestContext
{
    [Fact]
    public void NavMenuRendersCorrectly()
    {
        // Arrange
        var component = RenderComponent<NavMenu>();

        // Act
        var navLinks = component.FindAll("a.nav-link");

        // Assert
        Assert.Equal(3, navLinks.Count); // Ensure there are 3 navigation links
        Assert.Contains(navLinks, link => link.TextContent.Contains("Home"));
        Assert.Contains(navLinks, link => link.TextContent.Contains("Counter"));
        Assert.Contains(navLinks, link => link.TextContent.Contains("Weather"));
    }

    [Fact]
    public void NavMenuTogglesOnCheckboxClick()
    {
        // Arrange
        var component = RenderComponent<NavMenu>();

        // Act
        var checkbox = component.Find("input.navbar-toggler");
        checkbox.Change(true); // Simulate checking the checkbox

        // Assert
        Assert.True(checkbox.HasAttribute("checked")); // Verify the checkbox is checked
    }
}
