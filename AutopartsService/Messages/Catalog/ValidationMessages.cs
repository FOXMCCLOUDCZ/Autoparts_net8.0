namespace AutopartsService.Messages.Catalog
{
    public static class ValidationMessages
    {
        public static string NullEmptyMessageTitle(string propName)
        {
            return $"Vyplňte název {propName}.";
        }

        public static string MaximumCharacterAllowenceMessageTitle(string propName, int resctriction)
        {
            return $"V názvu {propName} byl překročen maximální počet znaků ({resctriction}).";
        }

        public static string GreaterThanMessage(string propName, int resctriction)
        {
            return $"{propName} minimální hodnota {resctriction}.";
        }

        public static string LessThanMessage(string propName, int resctriction)
        {
            return $"{propName} maximální hodnota {resctriction}.";
        }
    }
}