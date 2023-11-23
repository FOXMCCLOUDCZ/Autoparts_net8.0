namespace AutopartsService.Messages.Catalog
{
    public static class ValidationMessages
    {
        public static string NullEmptyMessage(string propName)
        {
            return $"Vyplňte pole {propName}.";
        }

        public static string NullEmptyMessageSelect(string propName)
        {
            return $"Vyberte {propName}.";
        }

        public static string MaximumCharacterAllowenceMessageMale(string propName, int resctriction)
        {
            return $"{propName} je omezen maximálním počtem znaků ({resctriction}).";
        }

        public static string MaximumCharacterAllowenceMessageFemale(string propName, int resctriction)
        {
            return $"{propName} je omezena maximálním počtem znaků ({resctriction}).";
        }

        public static string MaximumCharacterAllowenceMessageMiddle(string propName, int resctriction)
        {
            return $"{propName} je omezeno maximálním počtem znaků ({resctriction}).";
        }

        public static string GreaterThanMessage(string propName, int resctriction)
        {
            return $"Minimální hodnota {propName} je {resctriction}.";
        }

        public static string LessThanMessage(string propName, int resctriction)
        {
            return $"Maximální hodnota {propName} je {resctriction}.";
        }
    }
}