   M S B A M L   `   `   `  ����H  DProjetoCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjetoCSharp.ViewsProjetoCSharp.Views  5      !    ProjetoCSharp.Views.PerfilC   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ProjetoCSharp.Views     5        � Title$  
Seu Perfil��5      $	��623��6   $��539.5��6'   .��5
      � $��	0,0,-7,-5q�6   .+�5   
   �� -   5         ��Name$ 	imgPerfil��5      $	��143��6#   $	��140��60   $��52,56,347,398q�6<   �� 5   
   ���#EAF2F8$
��Left=�6#   $	��396��6>   $��
221,56,0,0q�6K   ���#eee9e9$	��Top=�6p   $��4��6�   �� 5   
   ���#EAF2F8$
��Left=�6#   $	��140��6>   $��
52,225,0,0q�6K   ���#eee9e9$	��Top=�6p   $	��140��6�    J� RenderTransformOrigin$ 	0.5,0.481&�6�   �� 5   
   -   5        $
��Sair��5      $
��Left=�6    $��
421,80,0,0q�6;   $	��Top=�6O   $��76��6g   6r   �� 5   
   -   5        $��Voltar��5      $
��Left=�6"   $��
340,80,0,0q�6=   $	��Top=�6Q   $��76��6i   6t   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	Historico��5      $
��Left=�6$   $	��309��6?   $��255,115,0,0q�6L   $	��Top=�6a   $	��243��6y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nome do Autonomo��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *
NomeAuto+  5      $
 Data��6%   $ 60 63    6>   �� *Dia+  5      $ Início��6%   $ 80 65    6@   �� *InicioExpediente+5      �� 5   
   ���	#FF47525E$
��Left=�6%   $��99��6@   $��	0,493,0,0q�6L   
���   �$	��Top=�6n   $	��533��6�   �� 5   
   -   5        $��Buscar��5      $
��Left=�6"   $��
255,80,0,0q�6=   $	��Top=�6Q   $��79��6i   6t   �� 5   
   -   5         ��Name$ NomeC��5      $��a��6   $
��Left=�6+   $��100,199,0,0q�6F   $	��Top=�6[   $ -1.235,0.499&�6s   �� 5   
   -   5        $
 Info��5      $��a��6   $
��Left=�6*   $��
81,254,0,0q�6E   $	��Top=�6Y   $ 	0.5,0.615&�6q   �� 5   
   -   5         ��Name$ txtLogo��5      $
��Left=�6%   $��	10,10,0,0q�6@   $
��Wrap=�6S   $��DIJJ Variedades��6g   $	��Top=�6~   �� 5   
   -	   5        	 ��Name$	 	historico��5      $ ��Ver Historico de mensagens��6$   $
��Left=�6I   $��304,437,0,0q�6d   $	��Top=�6y   $	��154��6�   6�   5      5       