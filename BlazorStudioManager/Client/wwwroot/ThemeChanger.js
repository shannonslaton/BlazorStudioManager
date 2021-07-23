var themeChanger =
{
    changeCss: function (cssFileUrl, isDark, ThemeShade)
    {

        document.body.classList.remove('light-theme');
        document.body.classList.remove('medium-theme');
        document.body.classList.remove('dark-theme');

        if (ThemeShade == "Light") {
            document.body.classList.add('light-theme');
        }
        else if (ThemeShade == "Medium") {
            document.body.classList.add('medium-theme');
        }
        else if (ThemeShade == "Dark") {
            document.body.classList.add('dark-theme');
        }

        var oldLink = document.getElementById("TelerikThemeLink"); // we have this id on the <link> that references the theme

        if (cssFileUrl === oldLink.getAttribute("href")) {
            return;
        }

        var newLink = document.createElement("link");
        newLink.setAttribute("id", "TelerikThemeLink");
        newLink.setAttribute("rel", "stylesheet");
        newLink.setAttribute("type", "text/css");
        newLink.setAttribute("href", cssFileUrl);
        newLink.onload = () => {
            oldLink.parentElement.removeChild(oldLink);
        };

        document.getElementsByTagName("head")[0].appendChild(newLink);
    }
}