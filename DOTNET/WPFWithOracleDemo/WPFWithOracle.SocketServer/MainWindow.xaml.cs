﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFWithOracle.MySocketServer;

namespace WPFWithOracle.SocketServer
{
  /// <summary>
  /// MainWindow.xaml 的交互逻辑
  /// </summary>
  public partial class MainWindow : Window
  {
    static SocketListener _listen;

    public MainWindow()
    {
      InitializeComponent();
      this.cmbUserList.Items.Add("All");
    }
    public void Start()
    {
      _listen = new SocketListener(80000, 4096, null);
      _listen.Init();
      _listen.OnSended += _listen_OnSended;
      _listen.OnMsgReceived += _listen_OnMsgReceived;
      _listen.MessageOut += _listen_MessageOut;
      _listen.AcceptUser += _listen_AcceptUser;

      string _ip = this.txtIP.Text;
      string _port = this.txtPort.Text;
      _listen.Start(int.Parse(_port), _ip);
      this.txtMSGList.Text += "Server Start\n";
    }

    void _listen_AcceptUser(string uid, string ip)
    {
      cmbUserList.Dispatcher.Invoke(new Action(() => { this.cmbUserList.Items.Add(uid); }));
    }

    void _listen_MessageOut(object sender, LogOutEventArgs e)
    {
      InsertText(txtMSGList, e.Mess);
    }

    void _listen_OnMsgReceived(string uid, string info)
    {
      InsertText(txtMSGList, uid + ":" + info);
    }

    void _listen_OnSended(string uid, string exception)
    {
      InsertText(txtMSGList, "Send to " + uid + ":" + exception);
    }

    private void btnSend_Click(object sender, RoutedEventArgs e)
    {
      if (this.cmbUserList.SelectedValue.ToString() == "All") 
        _listen.SendMessage(this.txtMSG.Text, "", true);
      else
        _listen.SendMessage(this.txtMSG.Text, this.cmbUserList.SelectedValue.ToString(), false);
    }

    private void btnStartServer_Click(object sender, RoutedEventArgs e)
    {
      Start();
    }

    public void InsertText(TextBlock control, string msg)
    {
      control.Dispatcher.Invoke(new Action(() => { control.Text += msg + "\n"; }));
    }
  }
}

