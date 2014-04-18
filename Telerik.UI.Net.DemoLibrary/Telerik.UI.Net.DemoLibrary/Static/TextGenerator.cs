using System;
using System.Collections.Generic;
using System.Linq;

namespace Telerik.UI.Net.DemoLibrary.Static
{
    public static class TextGenerator
    {
        private static Random rnd = new Random();

        public static string GetRandomText()
        {
            return LoremList[rnd.Next(0, LoremList.Count)];
        }

        public static string GetRandomLengthText()
        {
            return Lorem.Substring(rnd.Next(0, 200), rnd.Next(10, 50));
        }

        public static string GetEmail()
        {
            String name = Lists.NameList[rnd.Next(0, Lists.NameList.Count)].Replace(' ', '_').ToLower();
            return name + "@fakegmail.com";
        }

        #region Lotsa Text :D

        private static string Lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt purus libero, ut tincidunt nunc auctor vel. Donec a ultricies sapien, eu iaculis augue. Quisque posuere, libero sit amet lobortis rhoncus, metus velit egestas lectus, at commodo dolor quam eget ante. Integer at nulla convallis, ultricies urna vel, lobortis massa. Sed posuere ligula ipsum. Fusce eget congue purus. Praesent venenatis, augue fringilla semper interdum, lacus turpis sollicitudin odio, ac congue libero nulla non magna. Vestibulum egestas nulla vitae mi convallis facilisis. Mauris commodo neque mauris, at vehicula lectus mattis imperdiet. Quisque porttitor, lorem ornare lobortis mollis, magna est ultricies dolor, quis convallis ante neque nec quam. Aliquam ac justo quis sem lobortis rhoncus et non elit.";

        private static List<String> LoremList = new List<string>() {
            "Nulla lorem adipiscing. ",
            "Mi semper aenean ac ac aliquam. ",
            "Lobortis a id. ",
            "Varius ut enim quisque hendrerit imperdiet et etiam fringilla condimentum dapibus enim ante lectus cras magna netus in aliquam at sed erat sed sit risus quis luctus. ",
            "Quisque ipsum nullam. ",
            "Nunc nisl velit. ",
            "Magna voluptatem integer dignissim quam pellentesque. ",
            "Donec consequat varius viverra nisl eros. Id neque libero. ",
            "Erat congue ultricies. ",
            "Duis proin nibh libero parturient vel mauris sed in. ",
            "Litora vitae auctor laoreet eu et. ",
            "Egestas lectus massa. ",
            "Amet id aliquam suspendisse mi eu ornare volutpat et vivamus tristique dolor sapien habitasse tortor. ",
            "Massa rhoncus morbi. Mauris tellus nec. Lobortis sed luctus. Elit magna ut tempor est nunc magna ut eleifend.",
            "Maecenas imperdiet pellentesque pellentesque ligula nec amet hac commodo libero libero nisl turpis neque parturient. ",
            "Nulla donec nisl. ",
            "Pede dignissim in metus tristique arcu fringilla et pede. ",
            "Lorem aenean fringilla. ",
            "Tincidunt ligula accumsan. ",
            "Commodo ligula ultrices vel vivamus odio. ",
            "Id eros sed. ",
            "Eget orci sed. ",
            "Lorem arcu tempor. ",
            "Convallis sit et tempor lobortis donec. ",
            "Vehicula donec tempor vel sed id massa magna maecenas magna in ut. ",
            "Proin vehicula ac feugiat neque sed. ",
            "Id pellentesque sagittis maecenas iaculis non. ",
            "Viverra lectus litora mus magna felis. ",
            "Justo vivamus placerat ut tristique odio vel dui magna. ",
            "Mi magna risus. ",
            "Porttitor sit ac. ",
            "Pede arcu rutrum orci commodo euismod. ",
            "Mattis vulputate cursus mi et lacus suspendisse mollis et mattis lacus sed.",
            "Sapien mauris pede sem eget semper magnis enim justo. ",
            "Risus pulvinar proin fuga egestas sagittis. ",
            "Eros vitae proin. Laoreet nascetur volutpat. ",
            "Leo dolor urna tempor phasellus pede. ",
            "Ipsum vitae dictumst morbi donec amet in sed imperdiet. ",
            "Varius dui urna nulla nunc rutrum. ",
            "Wisi natoque leo ultricies justo recusandae et lacinia pulvinar leo a nulla. ",
            "Arcu amet purus." 
        };

        #endregion
    }
}
