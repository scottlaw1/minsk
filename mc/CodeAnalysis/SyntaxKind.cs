namespace Minsk.CodeAnalysis
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhitespaceToken,
        NumberToken,
        PlusToken,
        StarToken,
        MinusToken,
        SlashToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        
        // Expressions
        BinaryExpression,
        ParenthesizedExpression,
        LiteralExpression
    }
}
