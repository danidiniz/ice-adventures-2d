﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Passo {

    // Estou lidando com Undo da seguinte forma:
    // existem 2 tipos de Undo:
    // 1) Undo que movimenta o player no mapa
    // 2) Undo que é uma interação durante o movimento, ou seja, não são um Step.
    //    Ex.: IceQuebrado. O player movimenta e passa por cima de um, o AlgoPassouPorAqui do IceQuebrado não vai criar um Step novo,
    //         ele vai criar um interação nesse Step atual (do movimento)

    public List<UndoInteraction> interactions;

    // Interação de Objeto sempre vem antes de Interação de Ices
    public enum tiposDeInteraction
    {
        MOVIMENTAR, INTERACTION_ICE, INTERACTION_OBJETO
    }
    public tiposDeInteraction tipoDaInteractionQueAconteceu;

    protected abstract void DefinirTipoDePasso(tiposDeInteraction tipo);
}
