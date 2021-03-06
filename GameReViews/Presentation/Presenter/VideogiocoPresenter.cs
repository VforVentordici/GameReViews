﻿using GameReViews.Model;
using GameReViews.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    class VideogiocoPresenter
    {
        private VideogiocoRootView _rootView;
        private Sessione _sessione;
        private Videogioco _videogioco;

        public VideogiocoPresenter(Videogioco videogioco, Sessione sessione)
        {
            this._videogioco = videogioco;
            this._rootView = new VideogiocoRootView(videogioco, sessione);
            this._sessione = sessione;

            _rootView.Dock=DockStyle.Fill;


        }


        public VideogiocoRootView View
        {
            get
            {
                return _rootView;
            }
        }

        public Videogioco Videogioco
        {
            get { return _videogioco; }
            set
            {
                _videogioco = value;
                _rootView.Videogioco = value;
            }
        }






    }
}
