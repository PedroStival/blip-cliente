using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly TcpClient _tcpClient;
        private readonly List<string> _mensagens;
        private string? _usuarioSelecionado;
        public Form1()
{
            _tcpClient = new TcpClient();
            _mensagens = new List<string>();
            Conectar();
            InitializeComponent();
        }

        private  delegate void ReceberMensagemCallback(string data);
        private void ReceberMensagem(string data)
        {
            var comunicacao = JsonSerializer.Deserialize<ComunicacaoModel>(data);

            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = ReceberMensagem;
                Invoke(callback, data);
            }
            else
            {
                switch (comunicacao.Acao)
                {
                    case "atualizar-contatos":
                        var listaContatos = JsonSerializer.Deserialize<ListaContatoModel>(data);
                        AtualizarContatos(listaContatos.Contatos);
                        break;
                    case "mensagem":
                        var msg = JsonSerializer.Deserialize<EnviarMensagem>(data);
                        AtualizarMensagens(msg.Mensagem);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnRegistrarNickname_Click(object sender, EventArgs e)
        {     
            RegistrarUsuario();
        }

        private void Conectar()
        {
            var ip = IPAddress.Parse("127.0.0.1");
            int port = 5000;

            _tcpClient.Connect(ip, port);
            var thread = new Thread(o => ReceiveData((TcpClient)o));

            thread.Start(_tcpClient);
        }

        private void RegistrarUsuario()
        {
            var ns = _tcpClient.GetStream();

            var usuario = new RegistrarUsuarioModel("registrar-usuario", txtNickname.Text);

            byte[] buffer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(usuario));
            ns.Write(buffer, 0, buffer.Length);

            txtNickname.Enabled = false;
            btnRegistrarNickname.Enabled = false;
        }

        private void AtualizarContatos(List<ContatoModel> contatos)
        {
            listUsuarios.Items.Clear();
            listUsuarios.Items.Add("Todos");
            contatos.ForEach(contat => listUsuarios.Items.Add(contat.Nome));
        }

        private void AtualizarMensagens(string msg)
        {
            _mensagens.Add(msg);
            txtChat.Text = string.Empty;
            _mensagens.ForEach(x =>
            {
                txtChat.Text += x + Environment.NewLine;
            });
        }
        private void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                var data = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);

                ReceberMensagem(data);
            }
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            var ns = _tcpClient.GetStream();
            EnviarMensagem mensagem = null;

            if (_usuarioSelecionado == null)
            {
                mensagem = new EnviarMensagem("mensagem", txtTextoEnvio.Text);
            } else
            {
                mensagem = new EnviarMensagem("mensagem", txtTextoEnvio.Text, _usuarioSelecionado);
            }
           

            byte[] buffer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(mensagem));
            ns.Write(buffer, 0, buffer.Length);

            txtTextoEnvio.Text = string.Empty;
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItem == null) {
                _usuarioSelecionado = null;
            } else
            {
                if (listUsuarios.SelectedItem == _usuarioSelecionado)
                {
                    listUsuarios.ClearSelected();
                } else
                {
                    _usuarioSelecionado = listUsuarios.SelectedItem.ToString();
                }
            }
        }
    }
}
