namespace AutopartsService.Messages.Catalog
{
    public static class ValidationMessages
    {
        public static string NullEmptyMessage(string propName)
        {
            return $"Vyplňte pole {propName}.";
        }

        public static string MaximumCharacterAllowenceMessage(string propName, int resctriction)
        {
            return $"{propName} je omezena maximálním počtem znaků ({resctriction}).";
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