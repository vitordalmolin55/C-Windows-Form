/* este código limita o objeto TextBox a aceitar somente numeros */
private void textLoginKeypress(object sender, KeyPressEventArgs e)
{
    const char Delete = (char)8;
    e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
}
